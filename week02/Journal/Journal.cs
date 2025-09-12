using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the Lord’s hand in my life today?",
        "What was the strongest emotion I felt today?",
        "If I could do one thing again today, what would it be?"
    };

    private Random random = new Random();

    public void WriteEntry()
    {
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();
        entries.Add(new Entry(prompt, response));
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToCsv(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("Date,Prompt,Response");
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.ToCsvFormat());
            }
        }
        Console.WriteLine($"Journal saved to {filename} (CSV format).");
    }

    public void LoadFromCsv(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            entries.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                Entry e = Entry.FromCsvFormat(lines[i]);
                if (e != null)
                {
                    entries.Add(e);
                }
            }
            Console.WriteLine("Journal loaded successfully from CSV.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
