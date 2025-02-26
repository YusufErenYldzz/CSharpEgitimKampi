using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Metotlar

            //()
            //Geriye değer döndürmeyen metotlar
            //Customer - listele, ekle, sil, güncelle
            //void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali YILDIZ");
            //    Console.WriteLine("Ayşe YILDIZ");
            //    Console.WriteLine("Hakan ÖZTÜRK");
            //    Console.WriteLine("Merve ÇINAR");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Katman");

            //void CustomerCard(string name ,string surname)
            //{
            //    Console.WriteLine("Müşteri : " + name + " " + surname);
            //}

            //CustomerCard("Sena","Yeşil");
            //CustomerCard("Ahmet", "Kara");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(1,23,1);

            #endregion

            #region Geriye Değer Döndüren Metodlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yaşar";
            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metodlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo ="Ülke : "+ countryName+ " " +"- Başkent : " +capital + " " + "- Bayrak Rengi : " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz : ");
            //x = Console.ReadLine();

            //Console.Write("Ülke Başkentini Giriniz : ");
            //y = Console.ReadLine();

            //Console.Write("Ülkenin Bayrak Rengini Giriniz : ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metodlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(45, 36));
            //Console.WriteLine(Sum(14, 20));

            //int x, y;

            //Console.Write("Lütfen Toplamak İstedğiniz 1. Sayıyı Giriniz : ");
            //x = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Toplamak İstedğiniz 2. Sayıyı Giriniz : ");
            //y = int.Parse(Console.ReadLine());

            //Console.WriteLine(Sum(x, y));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
               
                if (result >= 50)
                {
                    return student + ": Dersi Başarı İle Geçmiştir -- " + "Ortalaması: " + result;
                }
                else
                {
                    return student + ": Dersi Geçememiştir -- " + "Ortalaması: " + result;
                }
            }
            Console.WriteLine(ExamResult("Ali", 25, 41, 65));
            Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));

            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            int x, y, z;
            string studentName;

            Console.Write("Öğrenci İsmini Giriniz : ");
            studentName = Console.ReadLine();

            Console.Write("Öğrencinin 1. Sınav Notunu Giriniz : ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Öğrencinin 2. Sınav Notunu Giriniz : ");
            y = int.Parse(Console.ReadLine());

            Console.Write("Öğrencinin 3. Sınav Notunu Giriniz : ");
            z = int.Parse(Console.ReadLine());

            Console.WriteLine(ExamResult(studentName,x, y, z));

            #endregion

            Console.Read();
        }
    }
}
