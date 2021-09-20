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
    public class AllPracticeAreasController : Controller
    {
        private readonly AppDbContext _context;

        public AllPracticeAreasController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "AllPracticeAreas";
            List<AllPracticeAreas> prc1 = _context.AllPracticeAreas.ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(prc1.Count / dataPage);

            List<AllPracticeAreas> prc2 = prc1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = prc1.Count;
            return View(prc2);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AllPracticeAreas model)
        {
            if (ModelState.IsValid)
            {
                _context.AllPracticeAreas.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int? prcId)
        {
            if (prcId == null && prcId <= 0)
            {
                return NotFound();
            }
            AllPracticeAreas all = _context.AllPracticeAreas.Find(prcId);
            return View(all);
        }

        [HttpPost]
        public IActionResult Update(AllPracticeAreas model)
        {
            if (ModelState.IsValid)
            {
                _context.AllPracticeAreas.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Duzgun duzelt!");
            return View();

        }

        public IActionResult Delete(int? prcId)
        {
            AllPracticeAreas all = _context.AllPracticeAreas.Find(prcId);
            _context.AllPracticeAreas.Remove(all);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
