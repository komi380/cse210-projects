using System;

public class Assignment
{
   private string _StudentName;
   private string _Topic;

   public string GetstudentName()
   {
      return _StudentName;
   }
   public void SetStudentName(string name)
   {
      _StudentName = name;
   }
   public string GetTopic()
   {
        return _Topic;
   }
   public void SetTopic(string topic)
   {
      _Topic = topic;
   }

   public string GetSummary()
   {
      return $"{_StudentName} - {_Topic}";
   }

}