using Justica2.Data;
using Justica2.Models;
using Justica2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Active = "Home";

            VmHome model = new VmHome();
            model.AllPracticeAreas = _context.AllPracticeAreas.ToList();
            model.VmPractice = new VmPractice();
            model.Laws = _context.Laws.ToList();
            model.News = _context.News.Include(v => v.NewsToTags)
                                      .ThenInclude(c => c.Tag)
                                      .Include(d => d.Comments)
                                      .ThenInclude(s => s.CustomUser).
                                      Include(u=>u.NewsNames).ToList();
            model.Our = _context.Ours.FirstOrDefault();
            model.OurParts = _context.OurParts.ToList();
            model.Testimonials = _context.Testimonials.ToList();
            model.PracticeAreas = _context.PracticeAreas.Include(f=>f.PracticeAreaNames).ToList();
            model.PracticeArea = _context.PracticeAreas.FirstOrDefault();
            model.PracticeAreaNames = _context.PracticeAreaNames.ToList();
            model.Teams = _context.Teams.Include(w => w.TeamToSocials).ThenInclude(f => f.TeamSocial).Include(b => b.Position).ToList();
            model.WhatWeDid = _context.WhatWeDids.FirstOrDefault();
            model.WeDidParts = _context.WeDidParts.ToList();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Subscribe(VmFooter model1)
        {
            if (ModelState.IsValid)
            {
                if (!_context.Subscribes.Any(v => v.Email == model1.Subscribe1.Email))
                {
                    model1.Subscribe1.CreatedDate = DateTime.Now;
                    _context.Subscribes.Add(model1.Subscribe1);
                    _context.SaveChanges();
                }
                ModelState.AddModelError("", "The same Email");
            }
            return RedirectToAction("Index", "Home");
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
