using System;

public class Entry
{
    public string Prompt; // Public field for the prompt
    public string Response; // Public field for the response
    public string Date; // Public field for the date

    public Entry(string prompt, string response)
    {
        Prompt = prompt; // Set the Prompt field
        Response = response; // Set the Response field
        Date = DateTime.Now.ToString("yyyy-MM-dd"); // Set the Date field
    }

    public string ToString()
    {
        return $"{Date} | Prompt: {Prompt} | Response: {Response}";
    }
}