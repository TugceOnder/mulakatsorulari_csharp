using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulakatSorulari
{
    internal class TekrarEdenHarf
    {
        public void TekrarEdenHarfiBul()
        {
            Console.Write("Yazı Giriniz:");
            string Yazi = Console.ReadLine();
            char[] Harfler = Yazi.ToCharArray();

            int EnBuyukHarfSayisi = 0;
            int EnBuyukEsitHarferSayisi = 0;
            char EnBuyukHarf = '\0';

            // iç içe döngüyle kelimenin harfleri kontrol edilerek aynı olan harf ve sayısı tespit ediliyor.
            for (int i = 0; i < Harfler.Length; i++)
            {
                int Toplam = 0;

                for (int j = 0; j < Harfler.Length; j++)
                {
                    // Aynı olan harfler sayılıyor.
                    // Eğer Daha önce yazdırılan harf ve sayısı kontrol edilerek tekrar sayılması engelleniyor.
                    if ((Harfler[i] == Harfler[j]) && (EnBuyukHarf != Harfler[i]))
                    {
                        Toplam++;
                    }
                }
                // Harf sayısı toplamı en son büyük harf sayısından büyükse yeni değerler atanıyor.
                if (Toplam > EnBuyukHarfSayisi)
                {
                    EnBuyukHarfSayisi = Toplam;
                    EnBuyukHarf = Harfler[i];
                }
                // Eğer sayılan harf sayısı toplamı en büyük harf sayısına eşitse EnBuyukEsitHarferSayisi değişkenine aktarılıyor.
                else if (Toplam == EnBuyukHarfSayisi)
                    EnBuyukEsitHarferSayisi = Toplam;

            }
            // En büyük harf sayısı, birbilerine eşit olan harflerin sayısından büyükse ekrana yazdırılıyor.
            // Değilse En fazla sayıya sahip bir değişkenin olmadığı ekrana yazdırılıyor.
            if (EnBuyukHarfSayisi > EnBuyukEsitHarferSayisi)
            {
                Console.WriteLine("{0} harfinden toplam {1} adet vardır.", EnBuyukHarf, EnBuyukHarfSayisi);
            }
            else
            {
                Console.WriteLine("En fazla sayıya sahip harf bulunamadı. ");
            }

            Console.ReadLine();
        }



    }

    

}
