using System;

class Entry
{
    public int _date;
    public string _promptText;
    public string _entryText;
    public void Activity()
    {
        Console.WriteLine($"{_date}: {_promptText} - {_entryText}");
    }
}