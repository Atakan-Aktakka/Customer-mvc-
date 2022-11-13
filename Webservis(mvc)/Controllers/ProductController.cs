using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System;
using Webservis_mvc_.Entites;
using Webservis_mvc_.Models;

namespace Webservis_mvc_.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Index2(int id)
        {
            return id.ToString();
        }
        
    }
}
