using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_tema_31_03_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            new StreamReader(Console.OpenStandardInput());      //citim din command line
            string[] fisier = File.ReadAllLines(args[0]);

            Procesare text = new Procesare(fisier);

           Console.WriteLine("In fisier sunt {0} caractere, {1} consoane, {2} vocale si {3} linii", text.NumarCaractere(), text.NumarConsoane(), text.NumarVocale(), text.NumarLinii());
          

            Console.ReadKey();

        }




        class Procesare
    {
        //variabile
        private string[] fisier;
        private int nrCaractere = 0;
        private int nrConsoane = 0;
        private int nrLinii = 0;
        private int nrVocale = 0;        

        private string v = "aeiouAEIOU";


        //constructorul
        public Procesare(string[] fisier)
        {
            this.fisier = fisier;
        }

        public int NumarLinii()
        {
            nrLinii = fisier.Length;
            return nrLinii;

        }

        public int NumarCaractere()
        {
            foreach (string line in fisier)
            {
                nrCaractere += line.Length;
            }

            return nrCaractere;
        }

        public int NumarVocale()
        {
            foreach (string line in fisier)
            {
                for (int i = 0; i < line.Length; i++)
                    for (int j = 0; j < v.Length; j++)
                        if (line[i] == v[j])
                            nrVocale++;
            }

            return nrVocale;
        }

        public int NumarConsoane()
        {
            bool vocala = false;
            foreach (string line in fisier)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    for (int j = 0; j < v.Length; j++)
                        if (line[i] == v[j])
                            vocala = true;

                    if ((vocala == false) && ((line[i] >= 'a') && (line[i] <= 'z') || (line[i] >= 'A') && (line[i] <= 'Z')))
                    {
                        nrConsoane++;
                    }
                }

            }

            return nrConsoane;
        }

    }
  
    }
}