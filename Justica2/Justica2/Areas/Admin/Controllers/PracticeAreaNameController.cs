using Justica2.Data;
using Justica2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "SuperAdmin,Admin")]
    public class PracticeAreaNameController : Controller
    {
        private readonly AppDbContext _context;

        public PracticeAreaNameController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "PracticeArea";
            List<PracticeAreaName> practice1 = _context.PracticeAreaNames.Include(w=>w.practiceArea).ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(practice1.Count / dataPage);

            List<PracticeAreaName> practice2 = practice1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = practice1.Count;
            return View(practice2);
        }

        public IActionResult Create()
        {
            ViewBag.PracticeArea = _context.PracticeAreas.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(PracticeAreaName model)
        {
            if (ModelState.IsValid)
            {
                _context.PracticeAreaNames.Add(model);
                _context.SaveChanges();
                ViewBag.PracticeArea = _context.PracticeAreas.ToList();
                return RedirectToAction("Index");
            }
            ViewBag.PracticeArea = _context.PracticeAreas.ToList();
            return View(model);
        }

        public IActionResult Update(int? prcId)
        {
            if (prcId == null && prcId <= 0)
            {
                ViewBag.PracticeArea = _context.PracticeAreas.ToList();
                return NotFound();
            }
            PracticeAreaName practice = _context.PracticeAreaNames.Find(prcId);
            ViewBag.PracticeArea = _context.PracticeAreas.ToList();
            return View(practice);
        }

        [HttpPost]
        public IActionResult Update(PracticeAreaName model)
        {
            if (ModelState.IsValid)
            {
                _context.PracticeAreaNames.Update(model);
                _context.SaveChanges();
                ViewBag.PracticeArea = _context.PracticeAreas.ToList();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Duzgun duzelt!");
            ViewBag.PracticeArea = _context.PracticeAreas.ToList();
            return View();

        }

        public IActionResult Delete(int? prcId)
        {
            PracticeAreaName practice = _context.PracticeAreaNames.Find(prcId);
            _context.PracticeAreaNames.Remove(practice);
            _context.SaveChanges();
            ViewBag.PracticeArea = _context.PracticeAreas.ToList();
            return RedirectToAction("Index");
        }
    }
}
