using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    public class Dependent : Person
    {

        public Dependent()
        {
            Random rand = new Random();
            DateTime dateToday = DateTime.Now;

           

            int year = rand.Next(dateToday.Year - 9, dateToday.Year - 2);
            int month = rand.Next(1, 12);
            int day = rand.Next(1, 31);
            try
            {
                BirthDate = new DateTime(year, month, day);
            }
            catch (Exception e)
            {
                BirthDate = new DateTime(2015, 02, 20);
            }
        }
    }
}



