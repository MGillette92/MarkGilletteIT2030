using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProgrammingFAQs.Models;

namespace ProgrammingFAQs.Controllers
{
    public class HomeController : Controller
    {
        private FAQContext context;

        public HomeController(FAQContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(string activeCategory = "all",
                                   string activeTopic = "all")
        {
            var data = new FAQListViewModel
            {
                ActiveCategory = activeCategory,
                ActiveTopic = activeTopic,
                Categorys = context.Categorys.ToList(),
                Topics = context.Topics.ToList()
            };

            IQueryable<FAQ> query = context.FAQs;
            if (activeCategory != "all")
                query = query.Where(
                    t => t.Category.CategoryID.ToLower() == activeCategory.ToLower());
            if (activeTopic != "all")
                query = query.Where(
                    t => t.Topic.TopicID.ToLower() == activeTopic.ToLower());
            data.FAQs = query.ToList();

            return View(data);
        }

    }
}