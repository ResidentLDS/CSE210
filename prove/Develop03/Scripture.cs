using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

public class Scripture
{
    private List<Word> Words;

    public Scripture(string _text)
    {
        Words = _text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void PrintScripture()
    {
        foreach (Word _word in Words)
        {
            _word.DisplayText();
        }
    }

    public void HideWords()
    {
        Random rand = new Random();
        int _times = 0;
        int _check = 0;

        int _length = Words.Count;
        foreach (Word _word in Words) // hides all the words if there are 3 or less words not hidden
        {
            bool _return = _word.CheckHide();
            if (_return)
            {
                _check += 1;
            }
        }
        if (_check >= Words.Count - 3)
        {
            _times = 3;
            foreach (Word _word in Words)
            {
                _word.Hide();
            }
        }
        else
        {
            while (_times < 3)
            {
                int number = rand.Next(Words.Count);
                bool _return = Words[number].Hide();
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
    
        foreach (Word _word in Words)
        {
            if (_word.CheckHide())
            {
                _hiddenCheck += 1;
            }
        }
        return _hiddenCheck == Words.Count;
    }
}