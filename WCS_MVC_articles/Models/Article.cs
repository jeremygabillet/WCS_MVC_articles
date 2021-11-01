using System;
namespace WCS_MVC_articles.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Contenu { get; set; }

        public Article()
        {
        }
    }
}
