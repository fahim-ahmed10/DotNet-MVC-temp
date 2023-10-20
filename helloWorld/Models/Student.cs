using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace helloWorld.Models
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }

        public float? Cgpa { get; set; }

    }
}