public class WritingAssignment : Assignment
{
    private string _title;

    // Notice the syntax here that the WritingAssignment constructor has 3 parameters and then
    // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        //setting any variables specific to the WritingAssignment class
        _title = title;
    }

    public string GetWritingInformation()
    {
        //calling the getter here because _studentName is private in the base class
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}