using System;

namespace Animals;

public class StartUp
{
    public static void Main(string[] args)
    {
        while (true)
        {
            string animalType = Console.ReadLine();
            if (animalType == "Beast!")
            {
                break;
            }

            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            try
            {
                switch (animalType)
                {
                    case "Dog":
                        Dog dog = new(tokens[0], int.Parse(tokens[1]), tokens[2]);
                        Console.WriteLine(animalType);
                        Console.WriteLine(dog);
                        break;
                    case "Frog":
                        Frog frog = new(tokens[0], int.Parse(tokens[1]), tokens[2]);
                        Console.WriteLine(animalType);
                        Console.WriteLine(frog);
                        break;
                    case "Cat":
                        Cat cat = new(tokens[0], int.Parse(tokens[1]), tokens[2]);
                        Console.WriteLine(animalType);
                        Console.WriteLine(cat);
                        break;
                    case "TomCat":
                        Tomcat tomcat = new(tokens[0], int.Parse(tokens[1]));
                        Console.WriteLine(animalType);
                        Console.WriteLine(tomcat);
                        break;
                    case "Kitten":
                        Kitten kitten = new(tokens[0], int.Parse(tokens[1]));
                        Console.WriteLine(animalType);
                        Console.WriteLine(kitten);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}