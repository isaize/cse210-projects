public class Rectangle : Shape
{
    private double length; // Encapsulation
    private double width; // Encapsulation

    public Rectangle(string color, double length, double width) : base(color)
    {
        this.length = length;
        this.width = width;
    }

    // Override GetArea method
    public override double GetArea()
    {
        return length * width; // Area of rectangle
    }
}