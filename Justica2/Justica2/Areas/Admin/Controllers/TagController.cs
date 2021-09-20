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
    public class TagController : Controller
    {
        private readonly AppDbContext _context;

        public TagController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "News";
            List<Tag> Tags1 = _context.Tags.Include(f => f.NewsToTags).ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(Tags1.Count / dataPage);

            List<Tag> Tags2 = Tags1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = Tags1.Count;
            return View(Tags2);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Tag model)
        {
            if (ModelState.IsValid)
            {
                _context.Tags.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int? TagId)
        {
            if (TagId == null && TagId <= 0)
            {
                return NotFound();
            }
            Tag Tag = _context.Tags.Find(TagId);
            return View(Tag);
        }

        [HttpPost]
        public IActionResult Update(Tag model)
        {
            if (ModelState.IsValid)
            {
                _context.Tags.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Duzgun duzelt!");
            return View();

        }

        public IActionResult Delete(int? TagId)
        {
            Tag Tag = _context.Tags.Find(TagId);
            _context.Tags.Remove(Tag);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
