using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulakatSorulari
{
    internal class MukemmelSayilar
    {

        public string MukkemelSayi(int mukkemelsayi)
        {
            int sum = 0;
            for (int i = 1; i <= mukkemelsayi / 2; i++)
            {
                if (mukkemelsayi % i == 0)
                {
                    sum += i;
                }
            }

            string result2 = "";
            //  if (sum == mukkemelsayi) 
            string result = $"{mukkemelsayi} {(sum == mukkemelsayi ? "bir mükemmel sayıdır" : "bir mükemmel sayı değildir")}";
            Console.WriteLine(result);

            return result2;


        }
    }
}
