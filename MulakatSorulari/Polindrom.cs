using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulakatSorulari
{
    internal class Polindrom
    {
        public bool IsPalindrom(int number)
        {

          
         //   Console.ReadLine();

            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = (reversedNumber * 10) + digit;
                number = number / 10;
            }
         

            return originalNumber == reversedNumber;
        }
    }
}
