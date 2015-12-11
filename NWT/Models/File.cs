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
        public int ID { get; set; }

        /*[StringLength(30, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Numbers and special characters are not allowed in the name.")]*/
        public string Name { get; set; }

        // dropdown ??
        public string Professor { get; set; }

        public DateTime Date { get { return DateTime.Now;} }

        // check if returns right value
        private int valueL = 0;
        private int valueD = 0;
        public int Likes { get { return valueL; } set { Likes = valueL; } }
        public int Dislikes { get { return valueD; } set { Dislikes = valueD; } }


        // foreign keys
        public User User { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public Subject Subject { get; set; }
    }
}