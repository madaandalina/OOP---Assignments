using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Num_OOP
{
    class Program
    {
       
        static void Main(string[] args)
        {
            /*Sa se creeze un tip de date denumit NumarMare pentru care se vor implementa operatorii + si * (de adunare si respectiv inmultire a numerelor foarte mari). Sa se utilizeze acest tip de date pentru determinarea:

                celui de al 100-lea termen din sirul lui Fibonacci 
                (primii doi termeni au valoarea 1, iar incepand de la al treilea termen, fiecare este suma anteriorilor doi termeni ai sai: 1, 1, 2, 3, 5, 8, 13, 21, ...)
                valorii 1000! (factorial).
            */


            BigNum big1 = new BigNum("1234567891234567891234");
            BigNum big2 = new BigNum("8888888888888888888888");     
            BigNum big3 = big1 + big2;
            Console.WriteLine("adunarea lui " + big1 + " cu " + big2 + " " + big3);

            BigNum big4 = big1 * big2;
            Console.WriteLine("inmultirea lui " + big1 + " cu " + big2 + " " + big4);


            Console.WriteLine();
            BigNum[] sirulFib = Fibonacci(100);
            Console.WriteLine("Cel de-al 100-lea element al sirului lui Fibonacci este: " + sirulFib[100]);




            Console.ReadLine();
        }
        static BigNum[] Fibonacci(int n)
        {
            BigNum[] sirulFib = new BigNum[n + 1];

            sirulFib[0] = new BigNum("0");

            if (n > 0)
            {
                sirulFib[1] = new BigNum("1");
            }

            if (n > 1)
            {
                BigNum a = new BigNum("0");
                BigNum b = new BigNum("1");
                BigNum aux;

                for (int i = 2; i <= n; i++)
                {
                    aux = a;
                    a = b;
                    b = b + aux;
                    sirulFib[i] = b;
                }
            }

            return sirulFib;
        }
    }
}
