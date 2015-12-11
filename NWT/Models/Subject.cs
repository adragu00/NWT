using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NWT.Models
{
    public class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Semester { get; set; }

        // foreign keys
        public Course Course { get; set; }
        public IEnumerable<File> Files { get; set; }
    }
}