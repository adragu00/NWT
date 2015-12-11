using NWT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NWT.Models
{
    public class Study
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }


        // foreign keys
        public IEnumerable<Course> Courses { get; set; }
    }
}