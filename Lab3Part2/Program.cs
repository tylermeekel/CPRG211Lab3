namespace Lab3Part2;

class Program
{
    static void Main(string[] args)
    {
        // Create Dog
        Console.Write("Type the dog's name: ");
        string dogName = Console.ReadLine();

        Console.Write("Type the dog's colour: ");
        string dogColour = Console.ReadLine();

        Console.Write("Type the dog's height: ");
        string dogHeightString = Console.ReadLine();
        double dogHeight = double.Parse(dogHeightString);
        
        Console.Write("Type the dog's age: ");
        string dogAgeString = Console.ReadLine();
        int dogAge = int.Parse(dogAgeString);

        Dog dog = new Dog(dogName, dogColour, dogHeight, dogAge);
        
        // Print dog attributes
        Console.WriteLine($"The dog's name is {dog.Name}");
        Console.WriteLine($"The dog's colour is {dog.Colour}");
        Console.WriteLine($"The dog's height is {dog.Height}");
        Console.WriteLine($"The dog's age is {dog.Age}");
        dog.Eat();
        Console.WriteLine($"The dog's cry is {dog.Cry()}");
        
        // Create Cat
        Console.Write("Type the cat's name: ");
        string catName = Console.ReadLine();

        Console.Write("Type the cat's colour: ");
        string catColour = Console.ReadLine();

        Console.Write("Type the cat's height: ");
        string catHeightString = Console.ReadLine();
        double catHeight = double.Parse(catHeightString);
        
        Console.Write("Type the cat's age: ");
        string catAgeString = Console.ReadLine();
        int catAge = int.Parse(catAgeString);

        Cat cat = new Cat(catName, catColour, catHeight, catAge);
        
        // Print Cat attributes
        Console.WriteLine($"The cat's name is {cat.Name}");
        Console.WriteLine($"The cat's colour is {cat.Colour}");
        Console.WriteLine($"The cat's height is {cat.Height}");
        Console.WriteLine($"The cat's age is {cat.Age}");
        cat.Eat();
        Console.WriteLine($"The cat's cry is {cat.Cry()}");
        
        // Create list of animals
        List<IAnimal> animals = [];

        Dog dog2 = new Dog("Beef", "Red", 3.3, 2);
        Cat cat2 = new Cat("Henry", "Purple", 2.2, 6);

        // Add animals to the list
        animals.Add(dog);
        animals.Add(dog2);
        animals.Add(cat);
        animals.Add(cat2);

        // Print each Animal name
        foreach (IAnimal animal in animals)
        {
            Console.WriteLine($"The animals name is: {animal.Name}");
        }
    }
}