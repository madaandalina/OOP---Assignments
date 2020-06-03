using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Num_OOP
{
    class BigNum
    {
        //campurile
        private string numar = "0";
        private int cifre;

        //proprietate read only
        public int Cifre
        {
            get
            {
               return cifre;
            }
        }


        //constructorul cu un parametru
        public BigNum(string numar)
        {
            this.numar = numar;
            cifre = numar.Length;
        }

       

        public int this[int i]
        {
            get
            {
                return numar[i] - '0';
            }
        }

        
        public static BigNum operator +(BigNum x, BigNum y)
        {
            int litAddcifre, bigAddcifre;
            BigNum littleAdd, bigAdd;

            if (x.cifre < y.cifre)
            {
                litAddcifre = x.cifre;
                bigAddcifre = y.cifre;
                littleAdd = x;
                bigAdd = y;
            }
            else
            {
                litAddcifre = y.cifre;
                bigAddcifre = x.cifre;
                littleAdd = y;
                bigAdd = x;
            }

            int index = bigAddcifre - 1, carry = 0, sumOfTwoDigits;
            string sum = "";

            while (index > -1)
            {
                int indexForLitAdd = litAddcifre - (bigAddcifre - index);

                sumOfTwoDigits = indexForLitAdd > -1
                    ? bigAdd[index] + littleAdd[indexForLitAdd] + carry
                    : bigAdd[index] + carry;

                if (sumOfTwoDigits >= 10)
                {
                    carry = 1;
                    sumOfTwoDigits -= 10;
                }
                else
                {
                    carry = 0;
                }

                index--;

                sum = sumOfTwoDigits + sum;
            };

            if (carry == 1)
                sum = "1" + sum;

            return new BigNum(sum);
        }
        


        public static BigNum operator *(BigNum x, BigNum y)
        {
            int n = y.cifre;
            string stepper = "";
            BigNum sum, product = new BigNum("0");

            for (int i = n - 1; i >= 0; i--)
            {
                int m = y[i];

                sum = new BigNum("0");

                for (int j = 0; j < m; j++)
                    sum += x;

                product += new BigNum(Convert.ToString(sum) + stepper);
                stepper += "0";
            }

            return product;
        }


        //suprascrierea ToString
        public override string ToString()
        {
            return numar;
        }
    }


}




    

