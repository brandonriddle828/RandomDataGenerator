using RandomDataGenerator;

public class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Create a person: 1");
        Console.WriteLine("View all persons: 2");
        Console.WriteLine("Remove a Person: 3");
        Console.WriteLine("Get random last name: 4");
        Console.WriteLine("Get a random SSN: 5");
        Console.WriteLine("Get a random phone number: 6"); // prompt user for specific seperator

        Person person = new Person();
        Person p = new Person();
        /*
        person.GetFirstName();
        person.GetLastName();
        person.GetBirthDay();
        person.Age();
        p.GetBirthDay();
        p.GetLastName();
        p.GetFirstName();
        p.Age();
        /*
        Console.WriteLine(person.FirstName);
        Console.WriteLine(p.FirstName);
        Console.WriteLine(person.LastName);
        Console.WriteLine(p.LastName);
        Console.WriteLine(person.FirstName);
        Console.WriteLine(person.LastName);
        Console.WriteLine(person.FirstName);
        Console.WriteLine(person.LastName);
        */
        Console.WriteLine(person);
        Console.WriteLine(p);






    }
}