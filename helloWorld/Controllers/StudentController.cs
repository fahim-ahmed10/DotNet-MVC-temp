using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using helloWorld.Models;
using helloWorld.Models.Entity;

namespace helloWorld.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
       

        public ActionResult Index()
        {
            Database db = new Database();
            var students = db.Students.GetAll();

            
            return View(students);
        }

       /* public ActionResult List()
        {
            List<Student> students = new List<Student>();
            for(int i=0; i<10; i++)
            {
                Student s1 = new Student()
                {
                    Name = "Fahim Ahmed" + (i+1),
                    Id = "2020",
                    Dob = "120312"
                };
                students.Add(s1);
            }
            return View(students);
        }*/

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Student s)
        {
            Database db = new Database();
            db.Students.Add(s);

            return RedirectToAction("Index");
        }
   

    }
}
