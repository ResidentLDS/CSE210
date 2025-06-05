using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

public class Scripture
{
    private List<Word> words;

    public Scripture(string _text)
    {
        words = _text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void PrintScripture()
    {
        foreach (Word _word in words)
        {
            _word.DisplayText();
        }
    }

    public void HideWords()
    {
        Random rand = new Random();
        int _times = 0;
        int _check = 0;

        int _length = words.Count;
        foreach (Word _word in words) // hides all the words if there are 3 or less words not hidden
        {
            bool _return = _word.CheckHide();
            if (_return)
            {
                _check += 1;
            }
        }
        if (_check >= words.Count - 3)
        {
            _times = 3;
            foreach (Word _word in words)
            {
                _word.Hide();
            }
        }
        else
        {
            while (_times < 3)
            {
                int number = rand.Next(words.Count);
                bool _return = words[number].Hide();
                if (_return == true)
                {
                    _times += 1;
                }
                else
                {

                }
            }
        }
    }
    public bool AllWordsHidden()
    {
        int _hiddenCheck = 0;
    
        foreach (Word _word in words)
        {
            if (_word.CheckHide())
            {
                _hiddenCheck += 1;
            }
        }
        return _hiddenCheck == words.Count;
    }
}