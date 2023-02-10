using System;
// Scripture:
// John 4:14 - But whosoever drinketh of the water that I shall give him shall never thirst
// but the water that I shall give him shall be in him a well of water 
// springing up into everlasting life 
class Scripture 
{
    private List<Verse> _verses = new List<Verse>();

    public Scripture(List<string> verses)
    {
        foreach(string verseStr in verses)
        {
            Verse verse = new Verse(verseStr);
            _verses.Add(verse);
        }
    }

    public void Display()
    {
        foreach(Verse verse in _verses)
        {
            verse.Display();
        }
        
    }

    public bool HideWords(int count)
    {
        return false;
    }

    public bool IsAllHidden()
    {
        return false;
    }
}