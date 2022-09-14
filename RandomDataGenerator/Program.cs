using RandomDataGenerator;

public class Program
{
    static List<Person> allPersons = new List<Person>();

    static void Main(string[] args)
    {
        bool choice = true;
        do
        {
            try
            {

                Random rand = new Random();

               

                Console.WriteLine("Welcom to the Random Data Generator. Please select one of the six options.");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Create a person: 1");
                Console.WriteLine("View all persons: 2");
                Console.WriteLine("Remove a Person: 3");
                Console.WriteLine("Get random last name: 4");
                Console.WriteLine("Get a random SSN: 5");
                Console.WriteLine("Get a random phone number: 6"); // prompt user for specific seperator


                int menuOption = int.Parse(Console.ReadLine());
                Console.WriteLine();



                switch (menuOption)
                {
                    case 1:
                        {


                            try
                            {

                                Console.WriteLine("How many Persons would you like to Create?");
                                int numOFPersons = int.Parse(Console.ReadLine());

                                for (int i = 0; i < numOFPersons; i++)
                                {
                                    Person person1 = new Person(numOFPersons);
                                    Console.WriteLine(person1);
                                    allPersons.Add(person1);

                                }


                            }

                            catch (Exception e)
                            {
                                Console.WriteLine(e.StackTrace);
                                Console.WriteLine("Error, lets try this again");
                                choice = true;
                            }
                        }
                        break;


                    case 2:
                        {
                            try
                            {
                                if (allPersons.Count > 0)
                                {
                                    Console.WriteLine("press enter to see all persons");
                                    Console.ReadLine();
                                    for (int i = 0; i < allPersons.Count; i++)
                                    {
                                        Console.WriteLine(allPersons[i]);
                                        Console.WriteLine();

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("There hasnt been a person created. Dont worry i'll make one for you!");
                                    Console.WriteLine();
                                    Console.WriteLine("press enter to see the person I just created");
                                    Console.ReadLine();
                                    Person p = new Person();
                                    allPersons.Add(p);
                                    for (int i = 0; i < allPersons.Count; i++)
                                    {

                                        Console.WriteLine(allPersons[i]);
                                        Console.WriteLine();

                                    }
                                }
                            }

                            catch (Exception e)
                            {
                                Console.WriteLine("Error, lets try this again");
                                choice = true;
                            }
                        }
                        break;


                    case 3:
                        {

                            try
                            {
                                Console.WriteLine("Which person would you like to remove?");
                                Console.WriteLine();
                                for (int i = 0; i < allPersons.Count; i++)
                                {

                                    Console.WriteLine($"" + i + ":\n" + allPersons[i] + "\n");
                                    Console.WriteLine();

                                }
                                int choice1 = int.Parse(Console.ReadLine());
                                allPersons.RemoveAt(choice1);


                                Console.WriteLine("press enter to see new list");
                                Console.ReadLine();

                                for (int i = 0; i < allPersons.Count; i++)
                                {

                                    Console.WriteLine($"" + i + ":\n" + " " + allPersons[i] + "\n");
                                    Console.WriteLine();


                                }

                            }


                            catch (Exception e)
                            {
                                Console.WriteLine("Error, lets try this again");
                                choice = true;
                            }
                        }
                        break;


                    case 4:
                        {
                            try
                            {
                                Console.WriteLine("And the random last name is....");
                                Console.WriteLine();

                                Person b = allPersons[rand.Next(allPersons.Count)];


                                string randomLastName = b.LastName;
                                Console.WriteLine(randomLastName);
                                Console.WriteLine();
                            }


                            catch (Exception e)
                            {
                                Console.WriteLine("Error, lets try this again");
                                choice = true;
                            }
                        }
                        break;


                    case 5:
                        {
                            try
                            {
                                if (allPersons.Count > 0)
                                {
                                    Console.WriteLine("And the random SSN is....");
                                    Console.WriteLine();

                                    Person b = allPersons[rand.Next(allPersons.Count)];


                                    Console.WriteLine($"{b.SSN}");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("Theres isnt anybody in the list! Create a new person.");
                                    Console.WriteLine();
                                }

                            }

                            catch (Exception e)
                            {
                                Console.WriteLine("Error, lets try this again");
                                choice = true;
                            }
                        }
                        break;


                    case 6:
                        {
                            try
                            {
                                if (allPersons.Count>0)
                                {
                                Console.WriteLine("Which seperator would you like to use?");
                                Console.WriteLine();

                                Person c = allPersons[rand.Next(allPersons.Count)];


                                Console.WriteLine(c.Phone.Format(char.Parse(Console.ReadLine())));
                                Console.WriteLine();

                                }
                                    else
                                {
                                    Console.WriteLine("Theres isnt anybody in the list! Create a new person.");
                                    Console.WriteLine();
                                }
                        }

                            catch (Exception e)
                            {
                                Console.WriteLine("Error, lets try this again");
                                choice = true;
                            }
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("There was an error, please try again.");
                        }
                        break;
                }

                bool flag = false;
                do
                {
                    Console.WriteLine("Do you wish to exit the program?\n" +
            "1: Yes\n" +
            "2: No");
                    int answer = int.Parse(Console.ReadLine());

                    if (answer == 1)
                    {
                        flag = false;
                        choice = false;
                    }
                    else if (answer == 2)
                    {
                        flag = false;
                        choice = true;
                        Console.Clear();
                    }
                    else
                    {
                        flag = true;
                    }
                }

                while (flag == true);



            }




            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("Whoa.. Slow down and read the menu option.");
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------------");

            }
        }
        while (choice == true);
        
    }
        
}