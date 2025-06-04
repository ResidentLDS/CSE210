public class Scripture
{
    private List<Word> Words;
    private Reference ScriptureReference;

    public Scripture(string _text)
    {
        Words = _text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void DisplayScripture(string key)
    {
        
    }

}