using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NWT.Models
{
    public class Comment
    {
        /************   REGEX   ************/
        public int ID { get; set; }

        /*[Required]
        [StringLength(1024, MinimumLength = 1)]*/
        public string Text { get; set; }
        public DateTime Date { get { return DateTime.Now; } }


        // Foreign keys
        public virtual User User { get; set; }
        public virtual File File { get; set; }
    }
}