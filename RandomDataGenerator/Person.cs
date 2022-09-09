using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    public class Person
    {
     

        Random rand = new Random();


        private string[] fNames = { "Matthew", "Mark", "Luke", "John", "Haley", "Bob", "Brooke", "Randy", "Alice", "Bailey", };
        private string[] dependents = new string[10];

        private DateTime birthDate;
        private string firstName;
        private string lastName;
        private int age;
        private SSN ssn;
        private Dependent dependent;
        private Phone phone;


        
        
        public DateTime GetBirthDay()
        {
            DateTime start = new DateTime(1942, 1, 1);
            int range = (new DateTime(2004,1,1) - start).Days;

            birthDate = start.AddDays(rand.Next(range));
            birthDate.ToShortDateString();
      
            return birthDate;


        }

        public string GetLastName()
        {
            Array values = Enum.GetValues(typeof(LastName));
            Random random = new Random();
            LastName lname = (LastName)values.GetValue(random.Next(values.Length));
            lastName = lname.ToString();
            return lastName;
       
        }

        public string GetFirstName()
        {
            firstName = fNames[rand.Next(fNames.Length)];
            return firstName;
        }
        
        
        
        public string FirstName 
        {
            get { return firstName; }  
            init {firstName = GetFirstName(); }
        }
        public string LastName 
        {
            get { return lastName; }
            init { lastName = GetLastName(); } 
        }
        
        public DateTime BirthDate 
        {

            get     { return birthDate; }
            init    { birthDate =  GetBirthDay(); }

        }
        
        public string SSN 
        { 
            get     { return ssn.Number; }
            init    { ssn = new SSN(); }
        }
        public string Phone 
        {
            get { return phone.Number; }
            init { phone = new Phone(); } 
        }


        public int Age()
        {
            age = DateTime.Today.Year - birthDate.Year;
            return age;
        }

        public void AddDependent()
        {
            Person newDependent = new Dependent();

        }
        
        public override string ToString()
        {
            return
                $"First Name:           {firstName}\n"+
                $"Last Name:            {lastName}\n" +
                $"Birth Date:           {birthDate}\n" +
                $"Age:                  {age}\n" +
                $"SSN:                  {ssn}\n" +
                $"Phone:                {phone}\n";
              //  $"Dependents:           {}\n";*/



        }


        public Person()
        {
            GetFirstName();
            GetLastName();
            GetBirthDay();
            Age();
            

        }

    }
}
