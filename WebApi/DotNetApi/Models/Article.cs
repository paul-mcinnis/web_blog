using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetApi.Models
{
    public class Article
    {
        public long Id { get; set; }

        public string Title { get; set; }
    }
}
