using System;

public class MathAssignment : Assignment
{
    private string _TextbookSection;
    private string _Problems;

    public string GetTextbookSection()
    {
        return _TextbookSection;
    }
    public void SetTextbookSection(string section)
    {
        _TextbookSection = section;
    }
    public string GetProblems()
    {
        return _Problems;
    }
    public void SetProblems(string problems)
    {
        _Problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_TextbookSection} - {_Problems}";
    }
}