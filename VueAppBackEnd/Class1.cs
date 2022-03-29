using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;

namespace VueAppBackEnd
{
    public class Class1
    {
        public List<Article> Articles()
        {
            List<Article> Articles = new List<Article>();
            var newsApiClient = new NewsApiClient("abdac52f05f64ef5805779553a2218e3");
            var articlesResponse = newsApiClient.GetEverything(new EverythingRequest
            {
                Q = "Oorlog",
                SortBy = SortBys.Popularity,
                Language = Languages.NL,
                From = new DateTime(2018, 1, 25)
            });
            foreach (var article in articlesResponse.Articles)
            {
                Articles.Add(article);
               
            }
            return Articles;
        }
    }
}

