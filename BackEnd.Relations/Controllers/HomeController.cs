using BackEnd.Relations.DAL;
using BackEnd.Relations.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BackEnd.Relations.Controllers
{
    public class HomeController : Controller
    {
        readonly RelationsHome _context;

        public HomeController( RelationsHome context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            ViewBag.title = "Home";
            List<Chef> chefs = _context.Chefs.Include(c => c.ChefSocialMedias).Include(c=>c.Testimonials).Include(c=>c.Profession
            ).ToList();
           

            return View(chefs);
        }


        public IActionResult Chef() {

            ViewBag.title = "Chef/Details";
            List<Chef> chefs = _context.Chefs.Include(c => c.ChefSocialMedias).Include(c => c.Testimonials).Include(c => c.Profession
            ).ToList();


            return View(chefs);

        }
        public IActionResult Testimonials()
        {
            ViewBag.title = "Testimonal/Details";
            List<Chef> chefs = _context.Chefs.Include(c => c.ChefSocialMedias).Include(c => c.Testimonials).Include(c => c.Profession
            ).ToList();


            return View(chefs);

        }


    }
}
