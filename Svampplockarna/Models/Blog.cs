using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Svampplockarna.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please, fill in title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Post can not be empty")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Please, fill in author")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please, fill in the number of mushrooms")]
        public int Quantity { get; set; }
    }
}
