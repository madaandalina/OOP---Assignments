using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasa_Rational_OOP
{
    class Cmmdc
    {

        public static float Divizor(float a, float b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }



    /*

        public static int Divizor(int a, int b)
        {

            while (a != b)
            {
                if (a < b)
                {
                    b = b - a;
                }
                else if (a > b)
                {
                    a = a - b;
                }

            }
            return a;
        }
        */


    }
}
