using NWT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NWT.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }


        // foreign keys
        public Study Study { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
    }
}