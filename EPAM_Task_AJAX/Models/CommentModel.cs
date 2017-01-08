using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EPAM_Task_AJAX.Models
{
    public class CommentModel
    {
        [Required]
        public string User { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime Data { get; set; }
    }
}