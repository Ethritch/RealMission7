using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RealMission7.Models;
using RealMission7.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RealMission7.Controllers
{
    public class HomeController : Controller
    {

        private iBookRepository repo;
        public HomeController(iBookRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 10;

            var x = new BooksViewModel
            {
                Books = repo.Books
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };



            return View(x);
        }

       

      
    }
}
