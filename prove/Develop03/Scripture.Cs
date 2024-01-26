public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        _words.AddRange(words.Select(word => new Word(word)));
    }


    public bool HasVisibleWords()
    {
        return _words.Any(word => !word.IsHidden());
    }

    public void HideRandomWords(int numberOfWordsToHide)
    {
        Random random = new Random();
        
        if (_words.Count(word => !word.IsHidden()) <= numberOfWordsToHide)
        {
            foreach (var word in _words.Where(word => !word.IsHidden()))
            {
                word.Hide();
            }
        }
        else
        {
            for (int i = 0; i < numberOfWordsToHide; i++)
            {
                int index;
                do
                {
                    index = random.Next(_words.Count);

                } while (_words[index].IsHidden());

                _words[index].Hide();
            }
        }
    }

    
    public string GetDisplayText()
    {
        List<string> visibleWords = new List<string>();

        foreach (Word word in _words)
        {
            visibleWords.Add(word.IsHidden() ? new string('_', word.GetDisplayText().Length) : word.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()}: {string.Join(' ', visibleWords)}";
    }

 
}