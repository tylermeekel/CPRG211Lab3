namespace Lab3Part2;

public class Cat : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public double Height { get; set; }
    public int Age { get; set; }

    public Cat(string name, string colour, double height, int age)
    {
        Name = name;
        Colour = colour;
        Height = height;
        Age = age;
    }
    
    public void Eat()
    {
        Console.WriteLine("Cats eat mice");
    }

    public string Cry()
    {
        return "Meow!";
    }
}