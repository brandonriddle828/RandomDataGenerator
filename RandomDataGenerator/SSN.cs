using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    public class SSN
    {
        Random rand = new Random();
        private int[] ssnNumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


        /* link for invalid ssn number https://www.ssa.gov/kc/SSAFactSheet--IssuingSSNs.pdf */
        public string Number 
        {
            get;
            init;
        }

        public string GenerateInvalidNumber()
        {
            string invalidString = string.Empty;
            Random random = new Random();
            bool flag = false;

            do
            {
                invalidString = (ssnNumbers[rand.Next(ssnNumbers.Length)].ToString()  + ssnNumbers[rand.Next(ssnNumbers.Length)].ToString()  +
                    ssnNumbers[rand.Next(ssnNumbers.Length)].ToString()  + ssnNumbers[rand.Next(ssnNumbers.Length)].ToString() + 
                    ssnNumbers[rand.Next(ssnNumbers.Length)].ToString()  + ssnNumbers[rand.Next(ssnNumbers.Length)].ToString() + 
                    ssnNumbers[rand.Next(ssnNumbers.Length)].ToString()  + ssnNumbers[rand.Next(ssnNumbers.Length)].ToString() + 
                    ssnNumbers[rand.Next(ssnNumbers.Length)].ToString());

                Char[] array = invalidString.ToCharArray();



                    if (
                    array[0] == '9' || 
                    array[0] == '0' && array[1] == '0' && array[2] == '0' ||
                    array[3] == '0' && array[4] == '0' ||
                    array[5] == '0' && array[6] == '0' && array[7] == '0' && array[8] == '0'||
                    array[0] == '6' && array[1] == '6' && array[2] == '6')
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }


            }
            while (flag == false);


            return invalidString;
        }


        public SSN()
        {
           Number = GenerateInvalidNumber();
        }

        public override string ToString()
        {

            string socialSecurityNumber = Number;
            socialSecurityNumber = socialSecurityNumber.Insert(3, "-").Insert(6,"-");

            return socialSecurityNumber;
        }

    }

}
