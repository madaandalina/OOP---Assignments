using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace clasa_Rational_OOP
{
    class Rational
    {
        private float numarator;
        private float numitor;

        //constructorul default
        public Rational() : this(0, 1)   //numitorul e diferit de 0
        {
           
        }
        public Rational(float numarator, float numitor)
        {
            this.numarator = numarator;
            this.numitor = numitor;
        }

        //operatia de adunare
        public Rational Aduna(Rational r2)
        {
            Console.Write("Adunarea celor doua fractii este: ");
            Rational rezultat = new Rational();

            rezultat.numitor = numitor * r2.numitor;
            rezultat.numarator = numarator * r2.numitor + r2.numarator * numitor;
            return rezultat.Simplifica();
        }

        //operatia de SCADERE
        public Rational Diferenta(Rational r2)
        {
            Console.Write("Scaderea celor doua fractii este: ");
            Rational rezultat = new Rational();

            rezultat.numitor = numitor * r2.numitor;
            rezultat.numarator = numarator * r2.numitor - r2.numarator * numitor;

            return rezultat.Simplifica();
        }
        //operatia de INMULTIRE
        public Rational Inmultire(Rational r2)
        {
            Rational rezultat = new Rational();
            rezultat.numitor = numitor * r2.numitor;
            rezultat.numarator = numarator * r2.numarator;

            return rezultat.Simplifica();

        }

        //operatia de Impartire
        public Rational Inverse()
        {
            return new Rational(numitor, numarator);
        }

        public Rational Impartire(Rational r2)
        {
            return this.Inmultire(r2.Inverse()).Simplifica();
        }


        //operatia de ridicare la putere
        public Rational Putere(int k)
        {
            Console.Write("Ridicarea la puterea : ");
            return new Rational((int)Math.Pow(numarator, k), (int)Math.Pow(numitor, k));
        }

        public Rational(int v) : this(v, 1)
        {
            Console.Write("Rational(int)");
        }



        //*************************************************************operatorii de comparatie*******************************************************************
        //algoritmul de comparare pt < si > : ,, For any two fractions A=ab,B=cd take abcd=C. Then if C>1 you have A>B if C<1 then B<A follows, finally if C=1 obviously A=B."
        //o a treia fractie fictiva c= r10/r20...daca c<1 r10<r20....c>1 inversul e adev.
        public static bool operator <(Rational r10, Rational r20)
        {
            r10 = r10.Simplifica();
            r20 = r20.Simplifica();
            Rational r30 = r10.Impartire(r20);
            
            if((r10.numarator/r10.numitor)/(r20.numarator/r20.numitor)<1)
            {
                return true;
            }
            else { return false; }

        }

        public static bool operator >(Rational r10, Rational r20)
        {
            r10 = r10.Simplifica();
            r20 = r20.Simplifica();

            if ((r10.numarator / r10.numitor) / (r20.numarator / r20.numitor) > 1)
            {
                return true;
            }
            else { return false; }
        }

        //fractiile sunt egale, daca in varianta ireductibila numitorii si numaratorii sunt egali
        public static bool operator ==(Rational r10, Rational r20)
        {
            r10 = r10.Simplifica();
            r20 = r20.Simplifica();
            if (r10.numarator == r20.numarator && r10.numitor == r20.numitor)
            {
                return true;
            }
            else { return false; }
        }

        
        public static bool operator !=(Rational r10, Rational r20)
        {
            r10 = r10.Simplifica();
            r20 = r20.Simplifica();
            return !(r10 == r20);
        }



        //operatia de simplificare/ reducere a fractiei
        private Rational Simplifica()
        {
            float d = Cmmdc.Divizor(Math.Abs(numarator), Math.Abs(numitor));
            return new Rational(numarator / d, numitor / d);
        }

        //suprascrierea ToString
        public override string ToString()
        {
            return string.Format($"({numarator} / {numitor})", numarator, numitor);
        }

    }
}
