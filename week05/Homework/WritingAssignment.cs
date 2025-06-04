using System;

public class WritingAssignment : Assignment
{
    public string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWrirtingInformation()
    {
        return $"{_title} by {GetStudentName()} on {GetTopic()}";
    }
}