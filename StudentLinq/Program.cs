﻿using System;

namespace StudentLinq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("All students");
        //your code here
        Console.WriteLine();

        Console.WriteLine("Firstname of all students");
        //your code here
        Console.WriteLine();

        Console.WriteLine("All students, sorted by last name");
        //your code here
        Console.WriteLine();

        Console.WriteLine("All students, sorted descending by number of courses taken");
        //your code here
        Console.WriteLine();

        Console.WriteLine("Email addresses of all students who have scored 100 on a test");
        //your code here
        Console.WriteLine();

        Console.WriteLine("All students who have an average above 75 on their tests");
        //your code here
        Console.WriteLine();

        Console.WriteLine("Firstname and average from all students who have an average above 75 on their tests");
        //your code here
        Console.WriteLine();

        Console.WriteLine("All students who have taken an intermediate class (one without '101' in the name)");
        //your code here
        Console.WriteLine();
    }
}









































//Console.WriteLine("All students");
//DataAccess.GetAllStudents().ToList().ForEach(Console.WriteLine);
//Console.WriteLine();

//Console.WriteLine("Firstname of all students");
//DataAccess.GetAllStudents().Select(student => student.FirstName).ToList().ForEach(Console.WriteLine);
//Console.WriteLine();

//Console.WriteLine("All students, sorted by last name");
//DataAccess.GetAllStudents().OrderBy(student => student.LastName).ToList().ForEach(Console.WriteLine);
//Console.WriteLine();

//Console.WriteLine("All students, sorted descending by number of courses taken");
//DataAccess.GetAllStudents().OrderByDescending(student => student.CoursesTaken.Count).ToList().ForEach(Console.WriteLine);
//Console.WriteLine();

//Console.WriteLine("Email addresses of all students who have scored 100 on a test");
//DataAccess.GetAllStudents().Where(student => student.Exams.Any(exam => exam.Score == 100)).ToList().ForEach(Console.WriteLine);
//Console.WriteLine();

//Console.WriteLine("All students who have an average above 75 on their tests");
//DataAccess.GetAllStudents().Where(student => student.Exams.Average(exam => exam.Score)>75).ToList().ForEach(Console.WriteLine);
//Console.WriteLine();

//Console.WriteLine("Firstname and average from all students who have an average above 75 on their tests");
//DataAccess.GetAllStudents().Where(student => student.Exams.Average(exam => exam.Score) > 75).Select(student => new { Name = student.FirstName, Average = student.Exams.Average(exam => exam.Score) }).ToList().ForEach(Console.WriteLine);
//Console.WriteLine();

//Console.WriteLine("All students who have taken an intermediate class (one without '101' in the name)");
//DataAccess.GetAllStudents().Where(student => student.CoursesTaken.Any(course => !course.Name.Contains("101"))).ToList().ForEach(Console.WriteLine);
//Console.WriteLine();