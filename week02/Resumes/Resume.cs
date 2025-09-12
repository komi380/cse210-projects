using System;

using System.Collections.Generic;

public class Resume
{
    public string _name;
    public string _contactInfo;
    public List<Job> _workHistory;

    public Resume()
    {
        _workHistory = new List<Job>();
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Contact Info: {_contactInfo}");
        Console.WriteLine("Job History:");
        foreach (Job job in _workHistory)
        {
            job.Display();
        }
    }
}