using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArticleApp.Entities
{
    public class Writer:BaseEntity
    {
        [Required]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please enter a valid username.")]
        [StringLength(150)]
        public string Username { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string LastName { get; set; }
    }
}
