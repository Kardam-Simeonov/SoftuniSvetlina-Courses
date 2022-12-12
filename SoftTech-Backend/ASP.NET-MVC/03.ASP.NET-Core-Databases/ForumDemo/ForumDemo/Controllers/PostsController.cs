using ForumDemo.Data;
using ForumDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForumDemo.Controllers
{
    public class PostsController : Controller
    {
        private readonly ForumDbContext data;
        
        public PostsController(ForumDbContext data)
        {
            this.data = data;
        }

        public IActionResult All()
        {
            var posts = this.data
                .Posts
                .Select(p => new PostViewModel()
                {
                    Id = p.Id,
                    Content = p.Content
                })
                .ToList();

            return View(posts);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(PostFormModel model)
        {
            var post = new Post()
            {
                Content = model.Content
            };

            this.data.Posts.Add(post);
            this.data.SaveChanges();

            return RedirectToAction("All");
        }

        public IActionResult Edit(int id)
        {
            var post = this.data.Posts.Find(id);

            return View(new PostFormModel()
            {
                Content = post.Content
            });
        }

        [HttpPost]
        public IActionResult Edit(int id, PostFormModel model)
        {
            var post = this.data.Posts.Find(id);
            post.Content = model.Content;

            this.data.SaveChanges();

            return RedirectToAction("All");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var post = this.data.Posts.Find(id);

            this.data.Posts.Remove(post);
            this.data.SaveChanges();

            return RedirectToAction("All");
        }
    }
}
