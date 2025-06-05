using System.Collections.Concurrent;

class Word
{
    private string Text;
    private bool Hidden;

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }

    public void DisplayText()
    {

        if (Hidden)
        {
            foreach (char c in Text)
            {
                Console.Write("_");
            }
            Console.Write(" ");

        }
        else
        {
            Console.Write(Text);
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