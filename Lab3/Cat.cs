namespace Lab3;

public class Cat: Animal
{
    public Cat(string name)
    {
        Name = name;
        Colour = "blue";
        Age = 5;
    }
    
    public override void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }
}