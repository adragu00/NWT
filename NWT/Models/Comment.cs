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
        public int Id { get; set; }

        [Required]
        [StringLength(1024, MinimumLength = 1)]
        public string Text { get; set; }
        public DateTime Date { get; set { Date = DateTime.Now;} }

        public User Author { get; set; }
    }
}