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
    public class NewsNameController : Controller
    {
        private readonly AppDbContext _context;

        public NewsNameController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "News";
            List<NewsName> news1 = _context.NewsNames.Include(w => w.News).ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(news1.Count / dataPage);

            List<NewsName> news2 = news1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = news1.Count;
            return View(news2);
        }

        public IActionResult Create()
        {
            ViewBag.News = _context.News.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(NewsName model)
        {
            if (ModelState.IsValid)
            {
                _context.NewsNames.Add(model);
                _context.SaveChanges();
                ViewBag.News = _context.News.ToList();
                return RedirectToAction("Index");
            }
            ViewBag.News = _context.News.ToList();
            return View(model);
        }

        public IActionResult Update(int? newsId)
        {
            if (newsId == null && newsId <= 0)
            {
                ViewBag.News = _context.News.ToList();
                return NotFound();
            }
            NewsName news = _context.NewsNames.Find(newsId);
            ViewBag.News = _context.News.ToList();
            return View(news);
        }

        [HttpPost]
        public IActionResult Update(NewsName model)
        {
            if (ModelState.IsValid)
            {
                _context.NewsNames.Update(model);
                _context.SaveChanges();
                ViewBag.News = _context.News.ToList();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Duzgun duzelt!");
            ViewBag.News = _context.News.ToList();
            return View();

        }

        public IActionResult Delete(int? newsId)
        {
            NewsName news = _context.NewsNames.Find(newsId);
            _context.NewsNames.Remove(news);
            _context.SaveChanges();
            ViewBag.News = _context.News.ToList();
            return RedirectToAction("Index");
        }
    }
}
