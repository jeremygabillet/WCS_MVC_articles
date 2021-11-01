using System;
using Microsoft.EntityFrameworkCore;
using WCS_MVC_articles.Models;

namespace WCS_MVC_articles.Data
{
    public class MvcArticleContext : DbContext
    {
        public MvcArticleContext(DbContextOptions<MvcArticleContext> options) : base(options)
        {
        }

        public DbSet<Article> Article { get; set; }
    }
}
