using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EPAM_Task_AJAX.Models.ViewModels
{
    public class CommentViewModel
    {
        [Required]
        public string User { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string Data { get; set; }
    }
}