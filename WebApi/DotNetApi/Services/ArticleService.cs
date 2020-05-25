using System.Collections.Generic;
using DotNetApi.Models;

namespace DotNetApi.Services
{
    public interface IArticleService
    {
        Article GetArticle(long Id);
        IEnumerable<Article> GetArticles();

    }

    public class ArticleService : IArticleService
    {
        public Article GetArticle(long Id)
        {
            return new Article()
            {
                Id = Id,
                Title = "Hello World"
            };
        }

        public IEnumerable<Article> GetArticles()
        {
            List<Article> results = new List<Article>()
            {
                new Article() {Id = 1, Title = "Hello"},
                new Article() {Id = 1, Title = "World"},
            };

            return results;
        }
    }
}
