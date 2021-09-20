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
    public class TestimonialController : Controller
    {
        private readonly AppDbContext _context;

        public TestimonialController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "Testimonial";
            List<Testimonial> test1 = _context.Testimonials.ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(test1.Count / dataPage);

            List<Testimonial> test2 = test1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = test1.Count;
            return View(test2);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Testimonial model)
        {
            if (ModelState.IsValid)
            {
                _context.Testimonials.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int? testId)
        {
            if (testId == null && testId <= 0)
            {
                return NotFound();
            }
            Testimonial Testimonial = _context.Testimonials.Find(testId);
            return View(Testimonial);
        }

        [HttpPost]
        public IActionResult Update(Testimonial model)
        {
            if (ModelState.IsValid)
            {
                _context.Testimonials.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Duzgun duzelt!");
            return View();

        }

        public IActionResult Delete(int? testId)
        {
            Testimonial Testimonial = _context.Testimonials.Find(testId);
            _context.Testimonials.Remove(Testimonial);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
