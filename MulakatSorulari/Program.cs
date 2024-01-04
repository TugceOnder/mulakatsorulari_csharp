using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulakatSorulari
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Bir tane seçenek seçiniz  ");
            string secenek = Console.ReadLine();

            switch(secenek.ToLower() )
                {
                case "polindrom":

                    Polindrom polindrom = new Polindrom();
                    Console.Write("Bir sayı girin: ");
                    int sayi = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine(polindrom.IsPalindrom(sayi));

                    if (polindrom.IsPalindrom(sayi))
                        Console.WriteLine($"{sayi} bir palindrom sayıdır.");
                    else
                        Console.WriteLine($"{sayi} bir palindrom sayı değildir.");
                    Console.ReadLine();
                    break;

                case "mukemelsayi":

                    MukemmelSayilar mukemmelSayilar = new MukemmelSayilar();
                    Console.Write("Bir sayi giriniz ");
                    int mukemelsayi= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(mukemmelSayilar.MukkemelSayi(mukemelsayi));
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Lütfen tekrar deneyiniz ");
                    Console.ReadLine();
                    Console.ReadLine();
                    break;
            }
           
        }

        
      
    }
}
