using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seçilen_işlemi_yaptırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Birinci Sayıyı Giriniz");
            int sayi1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen İkinci Sayıyı Giriniz");
            int sayi2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen İşlem Türünü Seçiniz");
            Console.WriteLine("toplama=1, çıkarma=2, çarpma=3, bölme=4, mod bulma=5, karesini alma=6, ortalama alma=7");
            int islem = Int32.Parse(Console.ReadLine());
            if (islem == 1)
            {
                Console.WriteLine(sayi1 + sayi2); // Console.WriteLine("Toplama işlemi sonucu: " + (sayi1 + sayi2).ToString()) şeklinde olabilirdi
                Console.ReadLine();
            }
            else if (islem == 2)
            {
                Console.WriteLine(sayi1 - sayi2); //Console.WriteLine("Çıkarma işlemi sonucu:" + (sayi1 - sayi2).ToString()) şeklinde olabilirdi
                Console.ReadLine();
            }
            else if (islem == 3)
            {
                Console.WriteLine(sayi1 * sayi2); // Console.WriteLine("Çarpma işlemi sonucu: " + (sayi1 * sayi2).ToString()) şeklinde olabilirdi
                Console.ReadLine();
            }
            else if (islem == 4)
            {
                Console.WriteLine(sayi1 / sayi2); // Console.WriteLine("Bölme işleminin sonucu:" + (sayi1 / sayi2).ToString()) şeklinde olabilirdi //bölme işlemindeki hatalar burdada geçerli
                Console.ReadLine();
            }
            else if (islem == 5)
            {
                Console.WriteLine(sayi1 % sayi2); //Console.WriteLine("Mod bulma işleminin sonucu:" + (sayi1 % sayi2).ToString()) şeklinde olabilirdi
                Console.ReadLine();
            }
            else if (islem == 6)
            { 
                Console.WriteLine(sayi1 * sayi1); //Console.WriteLine("Birinci sayının karesi: " + (sayi1 * sayi1).ToString()) şeklinde olabilirdi
                Console.WriteLine(sayi2 * sayi2); //Console.WriteLine("İkinci sayının karesi: " + (sayi2 * sayi2).ToString()) şeklinde olabilirdi
                Console.ReadLine();
            }
            else if (islem == 7)
            { 
                Console.WriteLine((sayi1 + sayi2) / 2); //Console.WriteLine("Sayıların ortalaması: " + ((sayi1 + sayi2) / 2).ToString()) şeklinde olabilirdi // 5 ile 8 in ortalaması 6.5 ama sonuç 6 çıkıyor
                Console.ReadLine();
            }
        } 
    } 
}

