using System;
using System.Collections.Generic;
using System.Text;

namespace StaticAndExtension.Helpers {
     static class Extensions {
        public static int FindFactorial(this int number)
        {
            int factorial=1;

            if (number < 0)
            {
                Console.WriteLine("Negative numbers has not factorial result");
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
            }
            return factorial;


            //two version of FindaFactorial

        //public static void CalcFactorial(this int number)
        //{
        //    int i, factorial;
        //    factorial = number;

        //    if (number < 0)
        //    {
        //        Console.WriteLine("Negative numbers has not factorial result");
        //    }
        //    else if (number <= 1)
        //    {
        //        Console.WriteLine("{0}! {1}", number, factorial);
        //    }
        //    else
        //    {
        //        for (i = number - 1; i >= 1; i--)
        //        {
        //            factorial = factorial * i;
        //        }
        //        Console.WriteLine("\nFactorial of Given Number is: " + factorial);
        //    }

        }
    }
}
