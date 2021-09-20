using Justica2.Data;
using Justica2.Models;
using Justica2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly AppDbContext _context;

        public AboutUsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmAbout model = new VmAbout();
            model.Legal = _context.Legals.FirstOrDefault();
            model.Our = _context.Ours.FirstOrDefault();
            model.OurParts = _context.OurParts.ToList();

            ViewBag.Active = "About";

            return View(model);
        }

        
    }
}
