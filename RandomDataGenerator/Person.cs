using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    public class Person
    {
     


        private string[] _fNames = { "Matthew", "Mark", "Luke", "John", "Haley", "Bob", "Brooke", "Randy", "Alice", "Bailey", };

        private Dependent[] _dependents;


        public string FirstName { get; init; }
        public string LastName { get; init; }
        public DateTime BirthDate { get; init; }
        public SSN SSN { get; init; }
        public Phone Phone { get; init; }
        public Dependent Dependent { get; init; }

        public Person()
        {
            Random rand = new Random();
            FirstName = _fNames[rand.Next(_fNames.Length)];

            var lastArray = RandomDataGenerator.LastName.GetValues(typeof(LastName));
            var value = (LastName)lastArray.GetValue(rand.Next(lastArray.Length));
            this.LastName = value.ToString();
 

            DateTime dateToday = DateTime.Now;

            int year = rand.Next(dateToday.Year - 81, dateToday.Year - 19);
            int month = rand.Next(1, 12);
            int day = rand.Next(1, 31);
            try
            {
                BirthDate = new DateTime(year, month, day);
            }
            catch(Exception e)
            {
                BirthDate = new DateTime(1993, 02, 20);
            }

            this.SSN = new SSN();

            this.Phone = new Phone();


        }


        
         public Person(int numOfPersons)
            {
                Random rand = new Random();
                FirstName = _fNames[rand.Next(_fNames.Length)];

                var lastArray = RandomDataGenerator.LastName.GetValues(typeof(LastName));
                var value = (LastName)lastArray.GetValue(rand.Next(lastArray.Length));
                this.LastName = value.ToString();
            
            

                DateTime dateToday = DateTime.Now;

                int year = rand.Next(dateToday.Year - 81, dateToday.Year - 19);
                int month = rand.Next(1, 12);
                int day = rand.Next(1, 31);

            try
            {
                BirthDate = new DateTime(year, month, day);
            }
            catch (Exception e)
            {
                BirthDate = new DateTime(1993, 02, 20);
            }
            this.SSN = new SSN();

                this.Phone = new Phone();


            // Code For getting dependents.
            int n = rand.Next(10);
           this._dependents = new Dependent[n];

            for (int i = 0; i < n; i++)
            {
                Dependent dependent = new Dependent() ;
                _dependents[i] = dependent;

            }
        }
        


        public int GetAge()
        {
            var age = DateTime.Now - BirthDate;
            return age.Days / 365;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < _dependents.Length; i++)
            {
                Dependent d = _dependents[i];
                result.Append("Dependent Age:  " + d.GetAge() +"        "+ "Dependent Name:   " + d.FirstName + " " + LastName +
                "\n");
            }

            return
                $"----------------------------------------------------------------\n" +
                $"Name:             {FirstName} {LastName}\n" +
                $"Birthday:         {BirthDate.ToShortDateString()}\n" +
                $"Age:              {GetAge()}\n" +
                $"SSN:              {SSN}\n" +
                $"Phone:            {Phone.Number}\n" +
                $"Dependents:       \n{result}\n" +
                $"----------------------------------------------------------------\n";
        }
    }
}

// Below is the original Code I used. Needless to say... It was not good....


        
/*
Random rand = new Random();
private Dependent[] dependents;

private DateTime birthDate;
private string firstName;
private string lastName;
private int age;
private Dependent dependent;
Phone phone = new Phone();
SSN ssn = new SSN();
private string ssnNum;
private string phoneNum;



public virtual DateTime GetBirthDay()
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
    firstName = _fNames[rand.Next(_fNames.Length)];
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

public  DateTime BirthDate 
{

    get     { return birthDate; }
    init    { birthDate =  GetBirthDay(); }

}

public string SSN 
{ 
    get     { return SSN; }
    init    { SSN = new SSN().GenerateInvalidNumber(); }
}
public string Phone 
{
    get { return Phone; }
    init { Phone = new Phone().Format(); } 
}


public int Age()
{
    age = DateTime.Today.Year - birthDate.Year;
    return age;
}

public Dependent AddDependent()
{


    int n = rand.Next(10);
    dependents = new Dependent[n];

    Dependent dependent = new Dependent();

    for (int i = 0; i < n; i++)
    {

        dependents[i] = dependent;

    }
    return dependent;

}






public override string ToString()
{
    return
        $"First Name:           {firstName}\n" +
        $"Last Name:            {lastName}\n" +
        $"Birth Date:           {birthDate}\n" +
        $"Age:                  {age}\n" +
        $"SSN:                  {ssn}\n" +
        $"Phone:                {phone}\n"+
        $"Dependents:           {dependent}";



}


public Person()
{
    GetFirstName();
    GetLastName();
    GetBirthDay();
    Age();
    //AddDependent();

}

public Person(  int numOfPersons)
{
    for (int i = 0; i < numOfPersons; i++)
    {
        Person person = new Person();

    }
    GetFirstName();
    GetLastName();
    GetBirthDay();
    Age();
   // AddDependent();

}

}

}
*/