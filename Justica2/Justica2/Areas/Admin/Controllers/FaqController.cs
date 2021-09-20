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
    public class FaqController : Controller
    {
        private readonly AppDbContext _context;

        public FaqController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "Faq";
            List<Faq> faqs1 = _context.Faqs.Include(f=>f.FaqParts).ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(faqs1.Count / dataPage);

            List<Faq> faqs2 = faqs1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = faqs1.Count;
            return View(faqs2);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Faq model)
        {
            if (ModelState.IsValid)
            {
                _context.Faqs.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int? faqId)
        {
            if (faqId == null && faqId <= 0)
            {
                return NotFound();
            }
            Faq faq = _context.Faqs.Find(faqId);
            return View(faq);
        }

        [HttpPost]
        public IActionResult Update(Faq model)
        {
            if (ModelState.IsValid)
            {
                _context.Faqs.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Duzgun duzelt!");
            return View();

        }

        public IActionResult Delete(int? faqId)
        {
            Faq faq = _context.Faqs.Find(faqId);
            _context.Faqs.Remove(faq);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
