using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NWT.Models
{
    public class File
    {
        /************   REGEX   ************/
        public int Id { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Numbers and special characters are not allowed in the name.")]
        public string Name { get; set; }

        // dropdown ??
        public string Course { get; set; }

        // dropdown ??
        public int Semester { get; set; }

        // dropdown ??
        public string Professor { get; set; }

        public DateTime Date { get; set { Date = DateTime.Now;} }

        public int Likes { get; set { Likes = 0;} }
        public int Dislikes { get; set { Dislikes = 0;} }

        public User Author { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}