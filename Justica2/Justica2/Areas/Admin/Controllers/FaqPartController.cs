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
    public class FaqPartController : Controller
    {
        private readonly AppDbContext _context;

        public FaqPartController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "Faq";
            List<FaqPart> faqs1 = _context.FaqParts.Include(s=>s.Faq).ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(faqs1.Count / dataPage);

            List<FaqPart> faqs2 = faqs1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = faqs1.Count;
            return View(faqs2);
        }

        public IActionResult Create()
        {
            ViewBag.Faq = _context.Faqs.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(FaqPart model)
        {
            if (ModelState.IsValid)
            {
                _context.FaqParts.Add(model);
                _context.SaveChanges();
                ViewBag.Faq = _context.Faqs.ToList();
                return RedirectToAction("Index");
            }
            ViewBag.Faq = _context.Faqs.ToList();
            return View(model);
        }

        public IActionResult Update(int? faqPId)
        {
            if (faqPId == null && faqPId <= 0)
            {
                ViewBag.Faq = _context.Faqs.ToList();
                return NotFound();
            }
            FaqPart faq = _context.FaqParts.Find(faqPId);
            ViewBag.Faq = _context.Faqs.ToList();
            return View(faq);
        }

        [HttpPost]
        public IActionResult Update(FaqPart model)
        {
            if (ModelState.IsValid)
            {
                _context.FaqParts.Update(model);
                _context.SaveChanges();
                ViewBag.Faq = _context.Faqs.ToList();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Duzgun duzelt!");
            ViewBag.Faq = _context.Faqs.ToList();
            return View();

        }

        public IActionResult Delete(int? faqPId)
        {
            FaqPart faq = _context.FaqParts.Find(faqPId);
            _context.FaqParts.Remove(faq);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
