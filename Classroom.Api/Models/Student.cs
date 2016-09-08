using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Classroom.Api.Models
{
    public class Student
    {

        public int StudentId  { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}