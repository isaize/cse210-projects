public class Reference
{
    private string _reference;

    // Constructor for single verse
    public Reference(string reference)
    {
        _reference = reference;
    }

    public string GetReference()
    {
        return _reference;
    }
}