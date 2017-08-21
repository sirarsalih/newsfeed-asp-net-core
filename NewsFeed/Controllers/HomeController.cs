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
        private readonly List<string> _screenNames = new List<string>() {"bbcnews", "bbcbreaking", "bbcworld", "bbcarabic", "cnn", "cnnbrk", "cnnarabic",
            "reuters", "skynews", "skynewsarabia", "washingtonpost", "ap", "guardian", "nytimes", "time", "wsj" };
        private readonly List<Tweet> _tweets = new List<Tweet>();

        public HomeController(ITwitterService twitterService)
        {
            _twitterService = twitterService;
        }

        public IActionResult Index()
        {
            var sortedTweets = GetSortedTweets();
            return View(sortedTweets);
        }

        [HttpGet]
        public IActionResult Partial()
        {
            var sortedTweets = GetSortedTweets();
            return PartialView("~/Views/Partial/_Tweets.cshtml", sortedTweets);
        }

        private IOrderedEnumerable<Tweet> GetSortedTweets()
        {
            foreach (var sn in _screenNames)
            {
                var tweetsJson = _twitterService.GetTweetsJson(sn);
                var tweet = JsonConvert.DeserializeObject<List<Tweet>>(tweetsJson).First();
                var cleanTweet = _twitterService.CleanText(tweet);
                _tweets.Add(cleanTweet);
            }
            var sortedTweets = _tweets.OrderByDescending(x => x.Id);
            return sortedTweets;
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
