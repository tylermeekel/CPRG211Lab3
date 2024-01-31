namespace Lab3;

public class Dog : Animal
{
    public Dog(string name)
    {
        Name = name;
        Colour = "Red";
        Age = 2;
    }
    
    public override void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }
}