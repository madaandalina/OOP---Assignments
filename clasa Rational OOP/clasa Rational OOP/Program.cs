using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace clasa_Rational_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(1, 2);
            Rational r2 = new Rational(3, 4);
            Rational r3 = r1.Aduna(r2);
            Console.WriteLine($"{r1} + {r2} = {r3}");


            Rational r4 = new Rational(5);
            Rational r5 = r1.Diferenta(r2);
            Console.WriteLine($"{r1} - {r2} = {r5}");

            Console.Write("Inmultirea celor 2 fractii este: ");
            Rational r6 = r1.Inmultire(r2);
            Console.WriteLine($" {r1} * {r2} = {r6}");

            Console.Write("Impartirea celor 2 fractii este: ");
            Rational r7 = r1.Impartire(r2);
            Console.WriteLine($"{r1} / {r2} = {r7}");

            Console.WriteLine();
            int putere = 2;
            Rational r8 = r1.Putere(putere);
            Console.WriteLine($"{r1} ^ {putere} = {r8}");

            //*****************************************************comparatia fractiilor**************************************************************
            Console.WriteLine("**********************************************************************************************************************");
            Rational r10 =new Rational(1,2);       
            Rational r20 = new Rational (2,1);
           
            Console.WriteLine("fractia " + r10 + " este mai mica decat fractia " +r20 + "<---- "+ (r10 < r20));
            Console.WriteLine("fractia " + r10 + " este mai mare decat fractia " +r20 + "<---- "+ (r10 > r20));
            Console.WriteLine("fractia " + r10 + " este egala cu fractia       " +r20 + "<---- "+ (r10 == r20));
            Console.WriteLine("fractia " + r10 + " NU este egala cu fractia    " +r20 + "<---- "+ (r10 != r20));



            Console.Write("Rezulta ca: ");
            if (r10 < r20)
            {
                Console.WriteLine($"{r10} este o fractie mai mica decat {r20}");
            }
            if(r10 > r20)
            {
                Console.WriteLine($"{r10} este o fractie mai mare decat {r20}");
            }
            if(r10 == r20)
            {
                Console.WriteLine("fractiile sunt egale");
            }
            


            Console.ReadLine();

        }
    }
}
