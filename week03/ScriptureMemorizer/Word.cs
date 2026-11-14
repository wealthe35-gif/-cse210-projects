public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            string hiddenWord = "";
            for (int i = 0; i < _text.Length; i++)
            {
                hiddenWord = hiddenWord + "_";
            }
            return hiddenWord;
        }
        else
        {
            return _text;
        }
    }
}