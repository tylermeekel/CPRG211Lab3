namespace Lab3Part2;

public class Dog : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public double Height { get; set; }
    public int Age { get; set; }

    public Dog(string name, string colour, double height, int age)
    {
        Name = name;
        Colour = colour;
        Height = height;
        Age = age;
    }
    
    public void Eat()
    {
        Console.WriteLine("Dogs eat meat");
    }

    public string Cry()
    {
        return "Woof!";
    }
}