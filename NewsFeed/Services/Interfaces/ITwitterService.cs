using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsFeed.Models;

namespace NewsFeed.Services.Interfaces
{
    public interface ITwitterService
    {
        string GetTweetsJson(string screenName);
        Tweet CleanText(Tweet tweet);
    }
}
