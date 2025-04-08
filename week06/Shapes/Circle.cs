public class Circle : Shape
{
    private double radius; // Encapsulation

    public Circle(string color, double radius) : base(color)
    {
        this.radius = radius;
    }

    //Override GetArea method
    public override double GetArea()
    {
        return Math.PI * radius * radius; // Area of circle
    }
}