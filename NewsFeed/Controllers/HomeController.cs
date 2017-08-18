using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsFeed.Services.Interfaces;

namespace NewsFeed.Controllers
{
    public class HomeController : Controller
    {
        private ITwitterService _twitterService;

        public HomeController(ITwitterService twitterService)
        {
            _twitterService = twitterService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
