using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proietul_5_OOP__nr_NrComplexee
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("introdu nr complex 1: ");
            NrComplexe complex1 = new NrComplexe(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("introdu nr complex 2: ");
            NrComplexe complex2 = new NrComplexe(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
           

            NrComplexe sumaComplexe = complex1 + complex2;
            NrComplexe difComplexe = complex1 - complex2;
            NrComplexe inmComplexe = complex1 * complex2;
         

            Console.WriteLine("suma numerelor complexe este: " +complex1  + " + " + complex2 + " =" + sumaComplexe);
            Console.WriteLine("diferenta numerelor este: " + complex1 + " - " + complex2 + "=" + difComplexe);
            Console.WriteLine("inmultirea este: " + complex1 + " * " + complex2 + "=" + inmComplexe);

            Console.WriteLine("introdu puterea: ");
            int putere = int.Parse(Console.ReadLine());
            NrComplexe putereComplexe = complex1 ^ putere;
            Console.WriteLine("ridicarea la putere a unui lui complex1: " + putereComplexe);


            Console.ReadLine();
        }
    }

    internal class NrComplexe
    {
        //campuri
        private double parteReala;
        private double parteImag;

        //constructor default
        public NrComplexe() 
        {

        }

        //constructor 2 parametrii
        public NrComplexe(double parteReala, double parteImag)
        {
            this.parteReala = parteReala;
            this.parteImag = parteImag;
        }

       
        public static NrComplexe operator +(NrComplexe stanga, NrComplexe dreapta)
        {
            return new NrComplexe (stanga.parteReala + dreapta.parteReala, stanga.parteImag + dreapta.parteImag);
        }  

        public static NrComplexe operator -(NrComplexe stanga, NrComplexe dreapta)
        {
            return new NrComplexe(stanga.parteReala - dreapta.parteReala, stanga.parteImag - dreapta.parteImag);
        }

        public static NrComplexe operator *(NrComplexe stanga, NrComplexe dreapta)
        {
           return new NrComplexe(stanga.parteReala * dreapta.parteReala - stanga.parteImag * dreapta.parteImag,
                                 stanga.parteReala * dreapta.parteImag + stanga.parteImag * dreapta.parteReala);
        }
        public static NrComplexe operator ^(NrComplexe x, int putere)
        {
            NrComplexe result = x;

            for (int i = 0; i < putere - 1; i++)
            {
                result = result* x;
            }

            return result;
        }


        public override string ToString()
        {
         
            return "(" + parteReala + "," + parteImag + "i)";
        }




    }
}
