using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    public class Phone
    {
        /*
        private string phoneNumber=string.Empty;
        Random rand = new Random();
        private string areaCode;
        private string nextThreeDigits;
        private string lastFourDigits;
        private char seperator;
        */

        public string Number { get; init;} = String.Empty;

        public Phone()
        {
            Number = Format();

        }

        public string Format(char seperator = '-')
        {
            Random random = new Random();

            int[] randomNumbers = new int[10];
            string phoneNumber = "";

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(1,10);

     
            if (randomNumbers[0] == 0 || randomNumbers[0]==1)
            {
                randomNumbers[0] = random.Next(2, 10);
  
            }
                phoneNumber += randomNumbers[i];
            }


            // Turn the array into one concatenated string
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                

            }

            phoneNumber = phoneNumber.Insert(3,seperator.ToString()).Insert(7,seperator.ToString());

            return phoneNumber;
        }
        public override string ToString()
        {
            return Number;
        }

    }
}
        /*

        public string getRandomAreaCode()
        {
            bool flag = false;

            do
            {
                areaCode = null;

                for (int i = 0; i < 11; i++)
                {
                    areaCode = rand.Next(10).ToString() + rand.Next(10).ToString() + rand.Next(10).ToString();
                }

                Char[] array = areaCode.ToCharArray();



                if (array[0] == '0' || array[0] == '1')
                {
                    flag = false;


                }
                else
                {
                    flag = true;
                }


            }
            while (flag == false);


            return areaCode;

        }

        public string getNextThreeDigits()
        {

           nextThreeDigits = null;

                for (int i = 0; i < 11; i++)
                {
                    nextThreeDigits = rand.Next(10).ToString() + rand.Next(10).ToString() + rand.Next(10).ToString();
                }


            return nextThreeDigits;

        }

        public string getLastFourDigits()
        {

            lastFourDigits = null;

            for (int i = 0; i < 11; i++)
            {
                lastFourDigits = rand.Next(10).ToString() + rand.Next(10).ToString() + rand.Next(10).ToString() +rand.Next(10).ToString();
            }


            return lastFourDigits;

        }

        public string getPhoneNumber()
        {

            phoneNumber = String.Format($"{areaCode}{seperator}{nextThreeDigits}{seperator}{lastFourDigits}");

            return phoneNumber;

        }

        public char getSeperator()
        {
            
            seperator = '-';

            return seperator;
        }

        public char setSeperator()
        {
            seperator = char.Parse(Console.ReadLine());
            return seperator;
        }


        public override string ToString()
        {
            return
               $"{areaCode}{seperator}{nextThreeDigits}{seperator}{lastFourDigits}";
        }

   

        public Phone(Person p, char seperator)
        {
            this.seperator = seperator;
           
            getRandomAreaCode();
            getNextThreeDigits();
            getLastFourDigits();
            getPhoneNumber();

        }
    }
}
*/