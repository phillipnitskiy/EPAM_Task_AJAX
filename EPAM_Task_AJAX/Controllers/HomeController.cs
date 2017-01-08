using EPAM_Task_AJAX.Models;
using EPAM_Task_AJAX.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EPAM_Task_AJAX.Controllers
{

    public class HomeController : Controller
    {

        private static List<CommentModel> _comments = new List<CommentModel>
        {
            new CommentModel
            {
                User = "Admin",
                Data = DateTime.Now,
                Text = "This is my first comment"
            },

            new CommentModel
            {
                User = "Admin",
                Data = DateTime.Now,
                Text = "This is my second comment"
            }
        };

        //
        // GET: /Home/

        [HttpGet]
        public ActionResult Index()
        {
            var comments = new List<CommentViewModel>();
            foreach (var item in _comments)
            {
                comments.Add(new CommentViewModel
                {
                    User = item.User,
                    Text = item.Text,
                    Data = item.Data.ToLongTimeString()
                });
            }

            CommentsViewModel commentsViewModel = new CommentsViewModel
            {
                Comments = comments,
                NewComment = new CommentsViewModel.CommentInput
                {
                    User = "Default",
                    Text = "Default"
                }
            };

            return View(commentsViewModel);
        }

        [HttpPost]
        public ActionResult AddComment(CommentsViewModel.CommentInput newComment)
        {
            var comment = new CommentModel
            {
                User = newComment.User,
                Data = DateTime.Now,
                Text = newComment.Text
            };

            _comments.Add(comment);
            
            if (Request.IsAjaxRequest())
            {
                var commentViewModel = new CommentViewModel
                {
                    User = newComment.User,
                    Data = DateTime.Now.ToLongTimeString(),
                    Text = newComment.Text
                };
                return PartialView(commentViewModel);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AddComment_JSON(CommentsViewModel.CommentInput newComment)
        {
            var comment = new CommentModel
            {
                User = newComment.User,
                Data = DateTime.Now,
                Text = newComment.Text
            };

            _comments.Add(comment);

            if (Request.IsAjaxRequest())
            {
                var commentViewModel = new CommentViewModel
                {
                    User = newComment.User,
                    Data = DateTime.Now.ToLongTimeString(),
                    Text = newComment.Text
                };
                return Json(commentViewModel);
            }

            return RedirectToAction("Index");
        }

    }
}
