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
    public class SubheaderController : Controller
    {
        private readonly AppDbContext _context;

        public SubheaderController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "Subheader";
            List<Subheader> sub1 = _context.Subheaders.ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(sub1.Count / dataPage);

            List<Subheader> sub2 = sub1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = sub1.Count;
            return View(sub2);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Subheader model)
        {
            if (ModelState.IsValid)
            {
                _context.Subheaders.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int? subId)
        {
            if (subId == null && subId <= 0)
            {
                return NotFound();
            }
            Subheader Subheader = _context.Subheaders.Find(subId);
            return View(Subheader);
        }

        [HttpPost]
        public IActionResult Update(Subheader model)
        {
            if (ModelState.IsValid)
            {
                _context.Subheaders.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Duzgun duzelt!");
            return View();

        }

        public IActionResult Delete(int? subId)
        {
            Subheader Subheader = _context.Subheaders.Find(subId);
            _context.Subheaders.Remove(Subheader);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
