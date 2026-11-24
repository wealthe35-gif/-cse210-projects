public class MathAssignment : Assignment
{
  private string _textbookSection = "";
  private string _problems = "";

  public string GettextbookSection()
  {
    return _textbookSection;
  }

  public void SettextbookSection(string textbookSection)
  {
    _textbookSection = textbookSection;
  }

  public string GetProblems()
  {
    return _problems;
  }

  public void SetProblems(string problems)
  {
    _problems = problems;
  }

  public string GetSummary()
  {
    return $"Section {_textbookSection} Problems {_problems}";
  }
}