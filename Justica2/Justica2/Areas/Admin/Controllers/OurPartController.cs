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
    public class OurPartController : Controller
    {
        private readonly AppDbContext _context;

        public OurPartController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "Our";
            List<OurPart> ourParts1 = _context.OurParts.Include(s => s.Our).ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(ourParts1.Count / dataPage);

            List<OurPart> ourParts2 = ourParts1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = ourParts1.Count;
            return View(ourParts2);
        }

        public IActionResult Create()
        {
            ViewBag.Our = _context.Ours.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(OurPart model)
        {
            if (ModelState.IsValid)
            {
                _context.OurParts.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            ViewBag.Our = _context.Ours.ToList();
            return View(model);
        }

        public IActionResult Update(int? ourPId)
        {
            if (ourPId == null && ourPId <= 0)
            {
                return NotFound();
            }
            OurPart ourPart = _context.OurParts.Find(ourPId);
            ViewBag.Our = _context.Ours.ToList();
            return View(ourPart);
        }

        [HttpPost]
        public IActionResult Update(OurPart model)
        {
            if (ModelState.IsValid)
            {
                _context.OurParts.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Duzgun duzelt!");
            ViewBag.Our = _context.Ours.ToList();
            return View();

        }

        public IActionResult Delete(int? ourPId)
        {
            OurPart ourPart = _context.OurParts.Find(ourPId);
            _context.OurParts.Remove(ourPart);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
