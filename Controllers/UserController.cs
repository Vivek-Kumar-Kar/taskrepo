using Microsoft.AspNetCore.Mvc;
using WebAppUsers.Models;

namespace WebAppUsers.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
        {
           new User()
            {
                UserId = 1,UserName="sam",UserPwd="sam@1256",UserEmail="sam@yahoo.com"
            },
           new User()
            {
                UserId = 2,UserName="amit",UserPwd="amit@1256",UserEmail="amit.com"
            },
           new User()
            {
                UserId = 3,UserName="kumar",UserPwd="kuar@1256",UserEmail="kuar.com"
            },
           new User()
            {
                UserId = 4,UserName="anisha",UserPwd="ani@1256",UserEmail="ani.com"
            },
           new User()
            {
                UserId = 5,UserName="vidisha",UserPwd="vid@1256",UserEmail="vid.com"
            },

        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                users.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
           
        }

    }
}
