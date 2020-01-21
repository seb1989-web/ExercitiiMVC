using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercitiiMVC.Models
{
    public class Student
    {
        public int Age { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class StudentaData
    {
        private static readonly List<Student> students = new List<Student>();
        public StudentaData() { }
        static StudentaData()
        {
            students.Add(new Student { Age = 30, FirstName = "ion", LastName = "vaile" });
            students.Add(new Student { Age = 30, FirstName = "ion", LastName = "vaile" });
            students.Add(new Student { Age = 30, FirstName = "ion", LastName = "vaile" });
            students.Add(new Student { Age = 30, FirstName = "ion", LastName = "vaile" });
            students.Add(new Student { Age = 30, FirstName = "ion", LastName = "vaile" });
            students.Add(new Student { Age = 30, FirstName = "ion", LastName = "vaile" });
            students.Add(new Student { Age = 30, FirstName = "ion", LastName = "vaile" });
            students.Add(new Student { Age = 30, FirstName = "ion", LastName = "vaile" });

        }
        public List<Student> GetStudents()
        {
            return students;
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        



    }
}