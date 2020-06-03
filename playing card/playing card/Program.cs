using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playing_card
{
    class Program
    {
        static void Main(string[] args)
        {
            Carte c = new Carte(ordine.asul, tip.inimaNeagra);
            Carte c2 = new Carte(ordine.sase, tip.trefla);
            Console.WriteLine(c);
            Console.WriteLine(c2);
            Console.ReadLine();
        }
        public enum ordine
        {
            asul, doi, trei, patru, cinci, sase, sapte, opt, noua, zece, juvete, dama, rege
        }
        public enum tip
        {
            inimaRosie,caro,trefla,inimaNeagra
        }

        class Carte
        {
            private ordine Ordine;
            private tip Tip;
            public Carte(ordine Ordine, tip Tip)
            {
                this.Ordine = Ordine;
                this.Tip = Tip;
            }
            public override string ToString()
            {
                return $"{Ordine} de {Tip}";
            }
        }


    }
}
