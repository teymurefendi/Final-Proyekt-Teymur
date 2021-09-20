using Justica2.Data;
using Justica2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "SuperAdmin,Admin")]
    public class SettingSocialController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SettingSocialController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "Settings";
            List<SettingSocial> social1 = _context.SettingSocials.Include(w => w.Settings).ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(social1.Count / dataPage);

            List<SettingSocial> setting2 = social1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = social1.Count;
            return View(setting2);
        }

        public IActionResult Create()
        {
            ViewBag.Settings = _context.Settings.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(SettingSocial model)
        {
            if (ModelState.IsValid)
            {
                _context.SettingSocials.Add(model);
                _context.SaveChanges();
                ViewBag.Settings = _context.Settings.ToList();
                return RedirectToAction("Index");
            }
            ViewBag.Settings = _context.Settings.ToList();
            return View(model);
        }

        public IActionResult Update(int? socId)
        {
            if (socId == null && socId <= 0)
            {
                ViewBag.Settings = _context.Settings.ToList();
                return NotFound();
            }
            SettingSocial setting = _context.SettingSocials.Find(socId);
            ViewBag.Settings = _context.Settings.ToList();
            return View(setting);
        }

        [HttpPost]
        public IActionResult Update(SettingSocial model)
        {
            if (ModelState.IsValid)
            {
                _context.SettingSocials.Update(model);
                _context.SaveChanges();
                ViewBag.Settings = _context.Settings.ToList();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Duzgun duzelt!");
            ViewBag.Settings = _context.Settings.ToList();
            return View();

        }

        public IActionResult Delete(int? socId)
        {
            SettingSocial setting = _context.SettingSocials.Find(socId);
            _context.SettingSocials.Remove(setting);
            _context.SaveChanges();
            ViewBag.Settings = _context.Settings.ToList();
            return RedirectToAction("Index");
        }
    }
}
