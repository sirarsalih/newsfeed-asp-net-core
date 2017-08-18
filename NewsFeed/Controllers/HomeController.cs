using Microsoft.AspNetCore.Mvc;
using NewsFeed.Services.Interfaces;

namespace NewsFeed.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITwitterService _twitterService;

        public HomeController(ITwitterService twitterService)
        {
            _twitterService = twitterService;
        }

        public IActionResult Index()
        {
            var tweetsJson = _twitterService.GetTweetsJson("bbcnews");
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
