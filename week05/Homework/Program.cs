using System;

public class Assignment
{
    // Attributes
    protected string studentName;
    protected string title;

    // Constructor
    public Assignment(string studentName, string title)
    {
        this.studentName = studentName;
        this.title = title;
    }

    // Method to get summary
    public string GetSummary()
    {
        return $"{title} assignment for {studentName}";
    }
}

public class MathAssignment : Assignment
{
    // Additional attributes for MathAssignment
    private string textbookSection;
    private string problems;

    // Constructor
    public MathAssignment(string studentName, string title, string textbookSection, string problems)
        : base(studentName, title)
    {
        this.textbookSection = textbookSection;
        this.problems = problems;
    }

    // Method to get homework list
    public string GetHomeworkList()
    {
        return $"Section: {textbookSection}, Problems: {problems}";
    }
}

public class WritingAssignment : Assignment
{
    // Additional attribute for WritingAssignment
    private string topic;

    // Constructor
    public WritingAssignment(string studentName, string title, string topic)
        : base(studentName, title)
    {
        this.topic = topic;
    }

    // Method to get writing information
    public string GetWritingInformation()
    {
        return $"Topic: {topic}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Create a derived class MathAssignment
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        // Create a derived class WritingAssignment
        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}