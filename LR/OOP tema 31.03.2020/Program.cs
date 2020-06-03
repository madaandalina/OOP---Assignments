using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tema_31._03._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            {


                // int[] v = { 6, 3, 1, 2, 6, 10, 7, 11, 16 };

                //Aveți la dispoziție un șir a[0], a[1],..., a[n - 1] de numere naturale.
                //Un element a[i](1 ≤ i < n - 1) îl numim LR dacă a[i] are toate elementele din șir aflate la stânga sa mai mici sau egale și toate elementele din dreapta sa mai mari sau egale cu a[i].
                //De exemplu, în șirul a = (6, 3, 1, 2, 6, 10, 7, 11, 16) sunt două elemente LR, valorile 6 și 11 de la pozițiile 5 și 8.

                int LR = 0;    
                int n = int.Parse(Console.ReadLine());
                int[] v = new int[n];

                Console.WriteLine("introdu elementele in vector: ");
                for (int i = 0; i < n; i++)
                {
                    v[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 1; i < n - 1; i++)
                {
                    bool stanga = true, dreapta = true;
                    for (int j = 0; j < i; j++)
                    {
                        if (v[i] < v[j]) stanga = false;
                    }
                    for (int j = i + 1; j < n; j++)
                    {
                        if (v[i] > v[j]) dreapta = false;
                    }
                    if ((stanga == true) && (dreapta == true))
                    {
                        LR++;
                        Console.WriteLine("v[i] este: " + v[i]);
                    }
                }
                Console.WriteLine("numarul de elemente LR este: " + LR);
            }



            Console.ReadLine();

}
    }
}
