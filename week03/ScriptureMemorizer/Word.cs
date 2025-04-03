public class Word
{
    public string Text { get; private set; }  //i learn this code on you tube on C# learning for beginners
    public bool IsHidden { get; private set; }

    // Constructor
    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    // Method to hide the word
    public void Hide()
    {
        IsHidden = true;
    }
}