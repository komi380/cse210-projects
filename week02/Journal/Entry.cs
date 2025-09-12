using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToShortDateString();
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"{Date} - {Prompt}\n{Response}\n";
    }

    private string EscapeCsv(string field)
    {
        if (field.Contains("\""))
        {
            field = field.Replace("\"", "\"\"");
        }
        if (field.Contains(",") || field.Contains("\n"))
        {
            field = $"\"{field}\"";
        }
        return field;
    }

    public string ToCsvFormat()
    {
        return $"{EscapeCsv(Date)},{EscapeCsv(Prompt)},{EscapeCsv(Response)}";
    }

    public static Entry FromCsvFormat(string line)
    {
        var fields = new System.Collections.Generic.List<string>();
        bool inQuotes = false;
        string current = "";

        foreach (char c in line)
        {
            if (c == '\"')
            {
                inQuotes = !inQuotes;
                current += c; 
            }
            else if (c == ',' && !inQuotes)
            {
                fields.Add(UnescapeCsv(current));
                current = "";
            }
            else
            {
                current += c;
            }
        }
        fields.Add(UnescapeCsv(current));

        if (fields.Count == 3)
        {
            Entry e = new Entry(fields[1], fields[2]);
            e.Date = fields[0];
            return e;
        }
        return null;
    }

    private static string UnescapeCsv(string field)
    {
        field = field.Trim();
        if (field.StartsWith("\"") && field.EndsWith("\""))
        {
            field = field.Substring(1, field.Length - 2).Replace("\"\"", "\"");
        }
        return field;
    }
}
