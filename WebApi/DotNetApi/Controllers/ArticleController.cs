using System.Collections.Generic;
using DotNetApi.Models;
using DotNetApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : Controller
    {
        private IArticleService _articleService;


        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        // api/Article
        [HttpGet]
        public IEnumerable<Article> Get()
        {
            return _articleService.GetArticles();
        }

        // api/Articles/5
        [HttpGet("{id}")]
        public Article Get(long id)
        {
            return _articleService.GetArticle(id);
        }
    }
}
