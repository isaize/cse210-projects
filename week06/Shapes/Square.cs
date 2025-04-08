public class Square : Shape
{
    private double side; // Encapsulation

    public Square(string color, double side) : base(color)
    {
        this.side = side;
    }

    // Override GetArea method
    public override double GetArea()
    {
        return side * side; // Area of square
    }
}