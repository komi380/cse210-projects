using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2020";
        job1._endYear = "2022";
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Apple";
        job2._startYear = "2019";
        job2._endYear = "2021";
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "John Doe";
        myResume._contactInfo = "john.doe@example.com";
        myResume._workHistory.Add(job1);
        myResume._workHistory.Add(job2);
        myResume.Display();

    }
}