namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the dog's name: ");
        string dogName = Console.ReadLine();

        Dog dog = new Dog(dogName);

        Console.WriteLine($"The dog's name is {dog.Name}");
        Console.WriteLine($"The dog's colour is {dog.Colour}");
        Console.WriteLine($"The dog's age is {dog.Age}");
        dog.Eat();
        
        Console.Write("Enter the cat's name: ");
        string catName = Console.ReadLine();

        Cat cat = new Cat(catName);

        Console.WriteLine($"The cat's name is {cat.Name}");
        Console.WriteLine($"The cat's colour is {cat.Colour}");
        Console.WriteLine($"The cat's age is {cat.Age}");
        cat.Eat();
    }
}