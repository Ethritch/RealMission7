using Microsoft.AspNetCore.Mvc;
using RealMission7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMission7.Components
{
    public class CategoryViewComponent : ViewComponent
    {
        private iBookRepository repo { get; set; }

        public CategoryViewComponent (iBookRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["Category"];

            var category = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(category);
        }
    }
}
