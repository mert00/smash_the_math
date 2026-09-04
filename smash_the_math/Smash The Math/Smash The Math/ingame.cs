using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Smash_The_Math
{
    public partial class ingame : Form
    {

        private Timer timer;
        private int timeLeft = 15;
        private int moveStep = 7;
        private int lives = 3; // Can sayısı
        private int correctAnswer; // Doğru cevap
        private int score = 0; // Puan değişkeni
        private bool isFormClosing = false; // Form kapanıyor mu kontrolü için
        private bool isCrushedCarVisible = false; // Ezilmiş araba görselinin görüldüğünü takip et
        private int level = 1; // Oyuncunun şu anki seviyesini takip edecek
        private int dogruSayisi = 0; // Doğru cevap sayısı
        private int yanlisSayisi = 0; // Yanlış cevap sayısı
        private string normalAracImagePath;
        private string ezilmisAracImagePath;



        public ingame(string normalAracPath, string ezilmisAracPath)
        {

            InitializeComponent();

            this.normalAracImagePath = normalAracPath;
            this.ezilmisAracImagePath = ezilmisAracPath;

            // Oyun başlarken seçilen arabayı PictureBox'a yükle
            arababox.Image = Image.FromFile(this.normalAracImagePath);

            InitializeTimer();
            this.AcceptButton = gonderbutonu; // Enter tuşu için butonu bağla
            cansayisi.Text = lives.ToString(); // Can sayısını başlangıçta göster
            GenerateQuestion(); // İlk soruyu oluştur
        }

        private void ingame_Load(object sender, EventArgs e)
        {
            cevapbox.Focus(); // TextBox'ı odakla
        }


        private void InitializeTimer()
        {
            // Timer ayarları
            timer = new Timer();
            timer.Interval = 1000; // Her 1 saniyede bir tetiklenecek
            timer.Tick += Timer_Tick;
            timer.Start();

            // Süre başlangıç değeri
            surelabel.Text = $"00:{timeLeft:D2}";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isFormClosing) return; // Form kapanıyorsa işlemleri yapma

            if (timeLeft > 0)
            {
                // Süreyi güncelle
                timeLeft--;
                surelabel.Text = $"00:{timeLeft:D2}";

                // 0 saniye kaldığında ezilmiş araba görselini göster
                if (timeLeft == 0 && !isCrushedCarVisible)
                {
                    ShowCrushedCarEffect(); // Ezilmiş araba efekti göster
                    MovePressMachine(); // Pres makinesini hareket ettir
                    isCrushedCarVisible = true; // Ezilmiş araba görselinin gösterildiğini işaretle
                    cevapbox.Focus(); // TextBox'ı odakla
                }

                // Pres makinesini her saniye moveStep kadar aşağıya hareket ettir
                pressbox.Location = new Point(pressbox.Location.X, pressbox.Location.Y + moveStep);
            }
            else
            {
                // Süre dolduğunda can kaybı işlemi
                LoseLife();
            }
        }

        private void gonderbutonu_Click(object sender, EventArgs e)
        {
            // Kullanıcının verdiği cevabı al
            string playerAnswer = cevapbox.Text;

            // Kullanıcının cevabını doğru cevapla karşılaştır
            if (playerAnswer == correctAnswer.ToString()) // String olarak karşılaştırma
            {
                AddScore(); // Puanı ekle
                dogruSayisi++; // Doğru cevabı artır

                if (level < 4) // <-- DEĞİŞİKLİK: Seviye 4'e kadar devam etmesi için 3, 4 olarak güncellendi.
                {
                    Sure_Press_Reset(); // Süreyi ve pres makinesini sıfırla
                    MessageBox.Show("Doğru cevap! Sıradaki bölüme geçiliyor.");
                    level++;
                    GenerateQuestion(); // Yeni soru oluştur
                    cevapbox.Text = "";
                    cevapbox.Focus(); // TextBox'ı odakla
                }
                else
                {
                    timer.Stop(); // Zamanlayıcıyı durdur
                    MessageBox.Show("Tebrikler! 4. bölümü başarıyla tamamladınız!"); // <-- DEĞİŞİKLİK: Mesaj güncellendi.
                    SaveScoreToDatabase(score); // Skoru kaydet
                    ShowResultForm(); // Sonuçları göster;
                    this.Close(); // Oyunu bitir ve ana ekrana dön
                }

            }
            else
            {
                yanlisSayisi++; // Yanlış cevabı artır
                Sure_Press_Reset(); // Süreyi ve pres makinesini sıfırla
                ShowCrushedCarEffect(); // Arabanın fotosu değişiyor, press makinesinin yeri ezilmiş gösteriliyor, press makinesi hareket etmiyor,
                                        // 1 saniye hem ezilmiş araba görseli hem press makinesi sabit duruyor, düzgün araba görseli geliyor,
                                        // press makinesi ilk konumuna geliyor, press makinesi hareket etmeye başlıyor.

                LoseLife(); // Can sayısı 1 azalıyor, yeni can sayısı gösteriliyor, süre 15 saniye oluyor, timer tekrardan başlıyor,
                            // Can kaybettiniz mesajı geliyor.
                cevapbox.Text = "";
                cevapbox.Focus(); // TextBox'ı odakla
            }
        }


        private void ShowCrushedCarEffect()
        {
            // 1. Normal arabanın orijinal konumunu, daha sonra geri dönmek üzere sakla.
            Point originalLocation = arababox.Location;

            // 2. Resmi ezilmiş araba ile değiştir.
            arababox.Image = Image.FromFile(this.ezilmisAracImagePath);

            // --- EN ÖNEMLİ KISIM ---
            // 3. Ezilmiş araba resminin yüksekliği farklı olduğu için konumu manuel olarak ayarla.
            //    Y değerini artırmak, arabayı ekranda AŞAĞIYA doğru indirir.
            //    Bu "15" değerini deneme yanılma ile mükemmel konumu bulana kadar değiştir.
            arababox.Location = new Point(originalLocation.X, originalLocation.Y + 30);
            // ------------------------

            // Press makinesi animasyon kodları...
            pressbox.Location = new Point(pressbox.Location.X, -50);
            moveStep = 0;
            pressbox.Location = new Point(pressbox.Location.X, pressbox.Location.Y + moveStep);

            Timer resetTimer = new Timer();
            resetTimer.Interval = 1000;
            resetTimer.Tick += (sender, e) =>
            {
                // 4. Resmi tekrar normal arabaya çevir.
                arababox.Image = Image.FromFile(this.normalAracImagePath);

                // 5. Arabanın konumunu en başta sakladığımız orijinal konumuna geri getir.
                arababox.Location = originalLocation;

                isCrushedCarVisible = false;
                moveStep = 7;
                pressbox.Location = new Point(pressbox.Location.X, pressbox.Location.Y + moveStep);
                pressbox.Location = new Point(pressbox.Location.X, -229);
                resetTimer.Stop();
            };
            resetTimer.Start();
        }

        private void LoseLife()
        {
            if (isFormClosing) return; // Form kapanıyorsa işlemleri yapma

            // Can sayısını azalt
            lives--;
            cansayisi.Text = lives.ToString(); // Güncellenen can sayısını göster

            // Can sayısı 0 olduğunda oyunu bitir
            if (lives <= 0)
            {
                timer.Stop();
                MessageBox.Show("Tüm canlar tükendi, oyun bitti!");

                // Veritabanına puanı kaydet
                SaveScoreToDatabase(score);  // Puanı veritabanına kaydet

                // Ana ekrana geri dönme
                ShowResultForm(); // Sonuç formunu göster
                this.Close(); // Şu anki formu kapat
            }
            else
            {
                timeLeft = 15;
                surelabel.Text = $"00:{timeLeft:D2}";
                timer.Start(); // Tekrar başlat

                // Ezilmiş araba efekti ekleme
                MessageBox.Show("Can kaybettiniz! Bir sonraki denemeye geçiliyor.");
            }
        }

        private void MovePressMachine()
        {
            // Pres makinesini y ekseninde -50 konumuna taşı
            pressbox.Location = new Point(pressbox.Location.X, -50);
        }

        private void Sure_Press_Reset()
        {
            timeLeft = 15;
            surelabel.Text = $"00:{timeLeft:D2}";
            timer.Start(); // Tekrar başlat
            pressbox.Location = new Point(pressbox.Location.X, -229);
        }

        // <-- YENİ: Faktöriyel hesaplamak için yardımcı bir metod ekledik.
        private int CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }


        private void GenerateQuestion()
        {
            Random random = new Random();

            if (level == 1) // 1. Bölüm (Standart işlemler)
            {
                int num1 = random.Next(1, 21);
                int num2 = random.Next(1, 21);
                string[] operators = { "+", "-", "*", "/" };
                string selectedOperator = operators[random.Next(operators.Length)];

                switch (selectedOperator)
                {
                    case "+":
                        correctAnswer = num1 + num2;
                        break;
                    case "-":
                        if (num1 < num2)
                        {
                            int temp = num1;
                            num1 = num2;
                            num2 = temp;
                        }
                        correctAnswer = num1 - num2;
                        break;
                    case "*":
                        correctAnswer = num1 * num2;
                        break;
                    case "/":
                        while (num1 % num2 != 0 || num2 == 0)
                        {
                            num1 = random.Next(1, 21);
                            num2 = random.Next(1, 21);
                        }
                        correctAnswer = num1 / num2;
                        break;
                }

                sorularbox.Items.Clear();
                sorularbox.Items.Add($"{num1} {selectedOperator} {num2} = ?");
                bolumler.Text = "1.Bölüm"; // Bölüm bilgisi güncelleniyor
            }
            else if (level == 2) // 2. Bölüm (Kesirli işlemler, tam sonuç)
            {
                int numerator1, denominator1, numerator2, denominator2;
                string[] operators = { "+", "-" }; // Sadece toplama ve çıkarma işlemleri
                string selectedOperator = operators[random.Next(operators.Length)];
                int resultNumerator; // Sonucun payı

                do
                {
                    numerator1 = random.Next(1, 11); // 1 ile 10 arasında pay
                    denominator1 = random.Next(1, 11); // 1 ile 10 arasında payda
                    numerator2 = random.Next(1, 11); // 1 ile 10 arasında pay
                    denominator2 = random.Next(1, 11); // 1 ile 10 arasında payda

                    if (selectedOperator == "+")
                    {
                        // Kesirli toplama
                        resultNumerator = (numerator1 * denominator2) + (numerator2 * denominator1);
                    }
                    else
                    {
                        // Kesirli çıkarma
                        resultNumerator = (numerator1 * denominator2) - (numerator2 * denominator1);

                        // Negatif sonucu önlemek için tekrar oluştur
                        while (resultNumerator < 0)
                        {
                            numerator1 = random.Next(1, 11);
                            denominator1 = random.Next(1, 11);
                            numerator2 = random.Next(1, 11);
                            denominator2 = random.Next(1, 11);
                            resultNumerator = (numerator1 * denominator2) - (numerator2 * denominator1);
                        }
                    }

                } while (resultNumerator % (denominator1 * denominator2) != 0); // Sonuç tam sayı olana kadar döngü

                correctAnswer = resultNumerator / (denominator1 * denominator2); // Doğru cevap tam sayı formatında

                // Soruyu oluştur ve ekrana yazdır
                sorularbox.Items.Clear();
                sorularbox.Items.Add($"{numerator1}/{denominator1} {selectedOperator} {numerator2}/{denominator2} = ?");
                bolumler.Text = "2.Bölüm"; // Sol tarafta "2.Bölüm" yazsın
            }
            else if (level == 3) // 3. Bölüm (Köklü işlemler, yalnızca toplama ve çıkarma)
            {
                int[] perfectSquares = { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100, 121, 144, 169, 196, 225, 256, 289, 324, 361, 400 }; // Tam kare sayılar
                int squareNumber1 = perfectSquares[random.Next(perfectSquares.Length)];
                int squareNumber2 = perfectSquares[random.Next(perfectSquares.Length)];

                string[] operators = { "+", "-" }; // Sadece toplama ve çıkarma
                string selectedOperator = operators[random.Next(operators.Length)];

                if (selectedOperator == "+")
                {
                    correctAnswer = (int)Math.Sqrt(squareNumber1) + (int)Math.Sqrt(squareNumber2);
                }
                else if (selectedOperator == "-")
                {
                    if (squareNumber1 < squareNumber2)
                    {
                        int temp = squareNumber1;
                        squareNumber1 = squareNumber2;
                        squareNumber2 = temp;
                    }
                    correctAnswer = (int)Math.Sqrt(squareNumber1) - (int)Math.Sqrt(squareNumber2);
                }

                sorularbox.Items.Clear();
                sorularbox.Items.Add($"√{squareNumber1} {selectedOperator} √{squareNumber2} = ?");
                bolumler.Text = "3.Bölüm"; // Bölüm bilgisi güncelleniyor
            }
            // <-- YENİ: 4. bölüm için kod bloğu eklendi.
            else if (level == 4) // 4. Bölüm (Faktöriyel İşlemleri)
            {
                int factNum1, factNum2;
                int result1, result2;
                string[] operators = { "+", "-", "*", "/" };
                string selectedOperator = operators[random.Next(operators.Length)];

                // Bölme işlemi için tam bölünebilen faktöriyeller bulunana kadar döngü
                do
                {
                    factNum1 = random.Next(1, 7); // 1 ile 7 arasında rastgele sayı (8 dahil değil)
                    factNum2 = random.Next(1, 7); // 1 ile 7 arasında rastgele sayı

                    result1 = CalculateFactorial(factNum1);
                    result2 = CalculateFactorial(factNum2);

                } while (selectedOperator == "/" && (result1 % result2 != 0 || result2 == 0));


                switch (selectedOperator)
                {
                    case "+":
                        correctAnswer = result1 + result2;
                        break;
                    case "-":
                        // Sonucun negatif olmaması için büyükten küçüğü çıkar
                        if (result1 < result2)
                        {
                            int tempNum = factNum1;
                            factNum1 = factNum2;
                            factNum2 = tempNum;

                            int tempResult = result1;
                            result1 = result2;
                            result2 = tempResult;
                        }
                        correctAnswer = result1 - result2;
                        break;
                    case "*":
                        correctAnswer = result1 * result2;
                        break;
                    case "/":
                        correctAnswer = result1 / result2;
                        break;
                }

                sorularbox.Items.Clear();
                sorularbox.Items.Add($"{factNum1}! {selectedOperator} {factNum2}! = ?");
                bolumler.Text = "4.Bölüm"; // Bölüm bilgisi güncelleniyor
            }
        }

        private void AddScore()
        {
            // Bölüme göre puan ekleyelim
            if (level == 1) // 1. bölüm
            {
                score += 100; // 1. bölümde 100 puan
            }
            else if (level == 2) // 2. bölüm
            {
                score += 200; // 2. bölümde 200 puan
            }
            else if (level == 3) // 3. bölüm
            {
                score += 300; // 3. bölümde 300 puan
            }
            // <-- YENİ: 4. bölüm için puan eklendi.
            else if (level == 4) // 4. bölüm
            {
                score += 400; // 4. bölümde 400 puan
            }
        }

        private void SaveScoreToDatabase(int score)
        {
            // Veritabanına bağlan ve skoru kullanıcı adıyla güncelle
            using (SqlConnection con = new SqlConnection(GlobalVariables.ConnectionString))
            {
                con.Open();

                // Kullanıcının mevcut skorunu al
                string getScoreQuery = "SELECT skor FROM dbo.KullaniciTablosu WHERE kullanici_adi = @kullanici_adi";
                int currentScore = 0;

                using (SqlCommand getScoreCmd = new SqlCommand(getScoreQuery, con))
                {
                    getScoreCmd.Parameters.AddWithValue("@kullanici_adi", GlobalVariables.KullaniciAdi);
                    object result = getScoreCmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        currentScore = Convert.ToInt32(result); // Mevcut skoru al
                    }
                }

                // Yeni skoru mevcut skora ekle
                int newScore = currentScore + score;

                // Veritabanında skoru güncelle
                string updateScoreQuery = "UPDATE dbo.KullaniciTablosu SET skor = @newSkor WHERE kullanici_adi = @kullanici_adi";
                using (SqlCommand updateScoreCmd = new SqlCommand(updateScoreQuery, con))
                {
                    updateScoreCmd.Parameters.AddWithValue("@newSkor", newScore); // Yeni toplam skor
                    updateScoreCmd.Parameters.AddWithValue("@kullanici_adi", GlobalVariables.KullaniciAdi); // Kullanıcı adı
                    updateScoreCmd.ExecuteNonQuery(); // Güncelleme işlemini gerçekleştir
                }
            }

        }

        private void ana_syf_Click(object sender, EventArgs e)
        {
            timer.Stop(); // Timer'ı durdur
            start_basla start = new start_basla();
            start.Show();
            this.Close();
        }

        private void ShowResultForm()
        {
            // Yeni formu oluştur
            sonuclar sonucFormu = new sonuclar();

            // Label'lara verileri aktar
            sonucFormu.label5.Text = $"{dogruSayisi}";
            sonucFormu.label6.Text = $"{yanlisSayisi}";
            sonucFormu.label7.Text = $"{score}";

            // Sonuç formunu göster
            sonucFormu.Show();
        }
    }
}