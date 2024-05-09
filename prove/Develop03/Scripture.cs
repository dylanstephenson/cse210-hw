public class Scripture 
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string scripture = text;
        string[] scriptureWords = scripture.Split(" ");
        foreach (string word in scriptureWords)
        {
            Word verseWord = new Word(word);
            _words.Add(verseWord);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            Random random = new Random();
            int index = random.Next(_words.Count);
            while (_words[index].IsHidden() == true)
            {
                index = random.Next(_words.Count);
            }
            if (_words[index].IsHidden() == false)
            {
                _words[index].Hide();
            }
        }
    }
    public string GetDisplayText()
    {
        List<string> scriptureWords = new List<string>();
        foreach (Word word in _words)
        {
            scriptureWords.Add(word.GetDisplayText());
        }
        string wholeScripture = String.Join(" ", scriptureWords);
        return $"{_reference.GetDisplayText()} \n {wholeScripture}";
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}