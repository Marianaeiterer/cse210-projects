
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(new char[] {' ','\t'}, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words)
        {   
           if(word != " ")
           {
                Word word1 = new Word(word);
                _words.Add(word1);
           }
            
        }

    }

    public void HideRandomWords(int numberToHide)
    {
    
        var rnd = new Random(); 
        bool hide = true;
        while(hide)
        {
            for(int i = 1; i <= 3; i++)
            {
                Word word = _words[rnd.Next(0, _words.Count)];
                if(!word.IsHidden())
                {
                    word.Hide();
                    hide = false;
                }
            }
        }

    }

    public bool IsCompletelyHidden()
    {
        int count = 0;
        foreach(Word word in _words)
        {
            if(word.IsHidden())
            {
                count++;
            }
        }

        if(count == _words.Count)
        {
            return true;
        }
        return false;
    }

    public string GetDisplayText()
    {
        string scripture = _reference.GetDisplayText();
        foreach(Word word in _words)
        {
            scripture += $" {word.GetDisplayText()}";
        }
        return scripture;
    }
}