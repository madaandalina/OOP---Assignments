using System;
using System.Collections.Generic;
using System.Text;

namespace Matrici_OOP
{
    internal class Matrici
    {
        //campurile membre
        private int randuri;
        private int coloane;
        private float[,] data;
        private int cifre = 1;

        public Matrici(int randuri, int coloane)
        {
            this.randuri = randuri;
            this.coloane = coloane;
            data = new float[this.randuri, this.coloane];
        }

        //constructorul default
        public Matrici(int n) : this(n, n)
        {

        }

        private static Random rnd = new Random();
        public void CreateMatrice()
        {
            for (int i = 0; i < this.randuri; i++)
            {
                for (int j = 0; j < this.coloane; j++)
                {
                    data[i, j] = Matrici.rnd.Next(10);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string formatString = "{0 ," + cifre + " }";

            for (int i = 0; i < this.randuri; i++)
            {
                for (int j = 0; j < this.coloane; j++)
                {
                    sb.AppendFormat(formatString, data[i, j]);
                    sb.Append(" ");
                }
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }


        //Adunarea a doua matrici
        public Matrici Aduna(Matrici m2)
        {
            if (this.randuri != m2.randuri && this.coloane != m2.coloane)
            {
                throw new ImpossibleMatrixOperationException();
            }

            int n = this.randuri;
            int m = this.coloane;

            Matrici a = new Matrici(n, m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a.data[i, j] = this.data[i, j] + m2.data[i, j];
                }
            }

            return a;
        }

        //scaderea a doua matrici
        public Matrici Scade(Matrici m2)
        {
            if (this.randuri != m2.randuri && this.coloane != m2.coloane)
            {
                throw new ImpossibleMatrixOperationException();
            }

            int n = this.randuri;
            int m = this.coloane;

            Matrici a = new Matrici(n, m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a.data[i, j] = this.data[i, j] - m2.data[i, j];
                }
            }

            return a;
        }



        public Matrici Inmulteste(Matrici m2)
        {
            if (this.coloane != m2.randuri)
            {
                throw new ImpossibleMatrixOperationException();
            }
            int n = this.randuri;
            int m = m2.coloane;

            Matrici a = new Matrici(n, m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    float suma = 0;
                    for (int k = 0; k < this.coloane; k++)
                    {
                        suma += this.data[i, k] * m2.data[k, j];
                    }
                    a.data[i, j] = suma;
                }
            }

            return a;
        }

       
  

        public Matrici Putere(int n)
        {
            Matrici a = new Matrici(this.randuri, this.coloane);
            while (n > 0)
            {
                a = this.Inmulteste(this);
                n--;
            }
            return a;
        }

       
      

     
    }
}
