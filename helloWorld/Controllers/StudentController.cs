using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using helloWorld.Models;

namespace helloWorld.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
       

        public ActionResult Index()
        {
            Student s1 = new Student()
            {
                Name = "Fahim Ahmed",
                Id = "2020",
                Dob = "120312"
            };

            

            return View(s1);
        }

        public ActionResult List()
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
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CreateSubmit(Student s)
        {

           // Student s = new Student();

            //form HttpRequestBase Request
           /* s.Name = Request["Name"];
            s.Id = Request["Id"];
            s.Dob = Request["Dob"];*/

            //form formCollection object
            /* s.Name = form["Name"];
             s.Id = form["Id"];
             s.Dob = form["Dob"];*/

            //form direct variable
            /* s.Name = Name;
             s.Id = Id;  
             s.Dob = Dob;*/
            return View(s);
        }

    }
}
