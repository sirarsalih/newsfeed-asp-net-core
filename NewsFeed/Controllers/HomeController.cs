using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NewsFeed.Models;
using NewsFeed.Services.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            var tweet = JsonConvert.DeserializeObject<List<Tweet>>(tweetsJson).First();
            return View(tweet);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
