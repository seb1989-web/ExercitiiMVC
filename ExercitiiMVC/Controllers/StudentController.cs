using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExercitiiMVC.Models;

namespace ExercitiiMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentaData studentaData;
        public StudentController()
        {
            this.studentaData = new StudentaData();
        }
        // GET: Student
        public ActionResult Index()
        {
            List<Student> lista = studentaData.GetStudents();
            return this.View(lista);
        }
        public ActionResult Create(Student student)
        {

            if(student.FirstName!= null && student.LastName!=null)
            {
                studentaData.AddStudent(student);
                
            }
            
            return View();
           
        }
        
        
    }
}