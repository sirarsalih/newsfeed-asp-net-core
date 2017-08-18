using System.Collections.Generic;
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
            var tweets = JsonConvert.DeserializeObject<List<Tweet>>(tweetsJson);
            return View(tweets);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
