public abstract class Shape
{
    private string color; // Encapsulation

    // Constructor
    protected Shape(string color)
    {
        this.color = color;
    }

    // Method to get color
    public string GetColor()
    {
        return color;
    }

    // Abstract method for area calculation
    public abstract double GetArea();
}