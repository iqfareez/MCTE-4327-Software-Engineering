using System;
using System.Collections.Generic;

public class Student
{
    public string Name;
    public double CGPA;
    public string Address;
    public List<Course> courses;
}

public class Course
{
    public string Title;
    public string Code;
}

class Program
{
    static void Main()
    {
        Student A = new Student { Name = "Ahmad", CGPA = 3.2, courses = new List<Course>() };
        A.courses.Add(new Course { Title = "Sofware Engineering", Code = "MCTE 4327" });
        Student B = new Student { Name = "Ibrahim", CGPA = 3.4, courses = new List<Course>() };
        B.courses.Add(new Course { Title = "Sofware Engineering", Code = "MCTE 4327" });
        Dictionary<string, Student> database = new Dictionary<string, Student>();
        database.Add("1511111", A);
        database.Add("1588888", B);
        Console.WriteLine(database["1511111"].Name);
        Console.ReadLine();
    }
}