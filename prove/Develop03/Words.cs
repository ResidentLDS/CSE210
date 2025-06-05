using System.Collections.Concurrent;

class Word
{
    private string _text;
    private bool Hidden;

    public Word(string text)
    {
        _text = text;
        Hidden = false;
    }

    public void DisplayText()
    {

        if (Hidden)
        {
            foreach (char c in _text)
            {
                Console.Write("_");
            }
            Console.Write(" ");

        }
        else
        {
            Console.Write(_text);
            Console.Write(" ");
        }
    }

    public bool Hide()
    {
        if (Hidden == false)
        {
            Hidden = true;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool CheckHide()
    {
        return Hidden;
    }
}