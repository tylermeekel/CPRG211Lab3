namespace Lab3Part2;

public interface IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public double Height { get; set; }
    public int Age { get; set; }

    void Eat();
    string Cry();
}