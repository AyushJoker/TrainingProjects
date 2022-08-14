using Microsoft.AspNetCore.Mvc;
using MyMVC_ControllerDemo.Models;
using System.Collections.Generic;

namespace MyMVC_ControllerDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> std = new List<Student>()
        {
            new Student{ID=1,fName="Ravi",lName="Dubey"},
            new Student{ID=2,fName="Mavi",lName="Rubey"},
            new Student{ID=3,fName="Navi",lName="Tubey"},
            new Student{ID=4,fName="Savi",lName="Jubey"}
        };
            
            return View(std);
        }
        public ActionResult StudentDetails()
        {
            Student s1 = new Student() { ID = 1, fName = "Ayush", lName = "Joker" };
           return View(s1);
        }
    }
}
