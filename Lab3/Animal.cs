namespace Lab3;

public abstract class Animal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }
    
    public abstract void Eat();
}