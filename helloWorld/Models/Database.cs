using helloWorld.Models.Entity.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace helloWorld.Models
{
    public class Database
    {
        public Students Students { get; set; }

        public Courses Courses { get; set; }
        public Faculties Faculties { get; set; }
        public Database() {
            string connString = @"Server=LAPTOP-RJ4VKTT3\SQLEXPRESS01;Database=UMS;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            Students = new Students(conn);
            Courses = new Courses();
            Faculties  = new Faculties();

        }
    }
}
