using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NWT.Models
{
    public class User
    {
        /************   REGEX   ************/
        public int ID { get; set; }

        /*[Required]
        [StringLength(30, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Numbers and special characters are not allowed in the name.")]*/
        public string Name { get; set; }

        /*[Required]
        [StringLength(30, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Numbers and special characters are not allowed in the last name.")]*/
        public string Lastname { get; set; }

        /*[Required]
        [StringLength(30, MinimumLength = 2)]*/
        public string Username { get; set; }

        /*[Required]
        [EmailAddress]*/
        public string Email { get; set; }

        /*[Required]
        [Range(1, 3)]*/
        public int Year { get; set; }


        // foreign keys
        public IEnumerable<File> UploadedFiles { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}