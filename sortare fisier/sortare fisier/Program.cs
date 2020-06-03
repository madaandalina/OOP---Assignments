using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace sortare_fisier
{
    internal class Compara : IComparer<Persoana>
    {
        public int Compare(Persoana x, Persoana y)
        {
            return string.Compare(x.ToString(), y.ToString(), new CultureInfo("ro-RO"), CompareOptions.None);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
    
                List<Persoana> listaNume = new List<Persoana>();

                string fileName = @"..\..\Input.txt";
                StreamReader sr = new StreamReader(fileName);
                string rand = sr.ReadLine();

                while (rand != null)
                {
                    Persoana currentPerson = new Persoana(rand);
                    listaNume.Add(currentPerson);
                    rand = sr.ReadLine();
                }

                Console.WriteLine("Lista nesortata: ");
                foreach (var persona in listaNume)
                {
                    Console.WriteLine(persona);
                }

                listaNume.Sort(new Compara());

                Console.WriteLine("**************************************************************");
                Console.WriteLine("Lista sortata: ");
                Console.WriteLine();

                foreach (var person in listaNume)
                {
                    Console.WriteLine(person);
                }

                fileName = @"..\..\output.txt";
                StreamWriter sw = new StreamWriter(fileName);

                foreach (var persona in listaNume)
                {
                    sw.WriteLine(persona);
                }
                sw.Close();

            Console.ReadKey();
        }  
    }
}
