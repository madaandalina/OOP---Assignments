using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrici_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //afisarile matricelor
            Matrici a1 = new Matrici(2, 2);
            a1.CreateMatrice();  
            Console.WriteLine($"Afisarea matricii a1 \n{a1}");


            Matrici a2 = new Matrici(2, 3);
            a2.CreateMatrice();
            Console.WriteLine($"Afisarea matricii a2 \n{a2}");

            Matrici a3 = new Matrici(3, 3);
            a3.CreateMatrice();
            Console.WriteLine($"Afisarea matricii a3 \n{a3}");

            Matrici a4 = new Matrici(3, 3);
            a4.CreateMatrice();
            Console.WriteLine($"Afisarea matricii a4 \n{a4}");

            //operatiile cu matrici

            Console.WriteLine($"Adunarea a doua matrici: ");
            Matrici a5 = a3.Aduna(a4);
            Console.WriteLine(a5);

            
            Console.WriteLine($"Scaderea a doua matrici: ");
            Matrici a6 = a3.Scade(a4);
            Console.WriteLine(a6);

            Console.WriteLine($"Inmultirea a doua matrici: ");
            Matrici a7 = a1.Inmulteste(a2);
            Console.WriteLine(a7);

            Console.WriteLine($"Ridicarea la putere a doua matrici: ");
            Matrici a8 = a1.Putere(3);
            Console.WriteLine(a8);


            Console.ReadLine();
        }
    }
}
