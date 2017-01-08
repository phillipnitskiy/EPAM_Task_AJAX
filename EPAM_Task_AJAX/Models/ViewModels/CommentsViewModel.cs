using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EPAM_Task_AJAX.Models.ViewModels
{
    public class CommentsViewModel
    {
        [UIHint("CommentsView")]
        public List<CommentViewModel> Comments { get; set; }

        [UIHint("CommentInput")]
        public CommentInput NewComment { get; set; }

        public class CommentInput
        {
            [Required]
            public string User { get; set; }
            [Required]
            public string Text { get; set; }
        }
    }
}