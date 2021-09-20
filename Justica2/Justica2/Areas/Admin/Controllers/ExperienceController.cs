using Justica2.Data;
using Justica2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "SuperAdmin,Admin")]
    public class ExperienceController : Controller
    {
        private readonly AppDbContext _context;

        public ExperienceController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "Experience";
            List<Experience> exp1 = _context.Experiences.ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(exp1.Count / dataPage);

            List<Experience> exp2 = exp1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = exp1.Count;
            return View(exp2);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Experience model)
        {
            if (ModelState.IsValid)
            {
                _context.Experiences.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int? expId)
        {
            if (expId == null && expId <= 0)
            {
                return NotFound();
            }
            Experience experience = _context.Experiences.Find(expId);
            return View(experience);
        }

        [HttpPost]
        public IActionResult Update(Experience model)
        {
            if (ModelState.IsValid)
            {
                _context.Experiences.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Duzgun duzelt!");
            return View();

        }

        public IActionResult Delete(int? expId)
        {
            Experience experience = _context.Experiences.Find(expId);
            _context.Experiences.Remove(experience);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
