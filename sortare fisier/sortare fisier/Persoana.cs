using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace sortare_fisier
{
    internal class Persoana
    {
        private string rand;
        private string[] nume;

        public Persoana(string rand)
        {
            this.rand = rand;
            char[] seps = { ' ', ',', ';' };
            nume = rand.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            CultureInfo myCIintl = new CultureInfo("ro-RO", false);

            for (int i = 0; i < nume.Length; i++)
            {
                string allLower = nume[i].ToLower(myCIintl);
                nume[i] = $"{char.ToUpper(allLower[0], myCIintl)}{allLower.Substring(1)}";
            }
        }

        public override string ToString()
        {
            string Name = "";
            for (int i = 1; i < nume.Length; i++)
            {
                Name += nume[i] + " ";
            }

            return $"{nume[0]}, {Name}";
        }
    }
}




