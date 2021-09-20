using Justica2.Data;
using Justica2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "SuperAdmin,Admin")]
    public class PracticeAreaController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PracticeAreaController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "PracticeArea";
            List<PracticeArea> practice1 = _context.PracticeAreas.Include(g=>g.PracticeAreaNames).Include(l=>l.Settings).ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(practice1.Count / dataPage);

            List<PracticeArea> practice2 = practice1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = practice1.Count;
            return View(practice2);
        }

        public IActionResult Create()
        {
            ViewBag.Settings = _context.Settings.ToList();
            ViewBag.PracticeAreaName = _context.PracticeAreaNames.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(PracticeArea model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {
                    if (!(model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif" || model.ImageFile.ContentType == "image/jpg"))
                    {
                        ModelState.AddModelError("", "You can only upload jpeg, png, and gif");
                        ViewBag.Settings = _context.Settings.ToList();
                        ViewBag.PracticeAreaName = _context.PracticeAreaNames.ToList();
                        return View(model);
                    }

                    if (model.ImageFile.Length > 2097152)
                    {
                        ModelState.AddModelError("", "You can only upload max 2 Mb size images");
                        ViewBag.Settings = _context.Settings.ToList();
                        ViewBag.PracticeAreaName = _context.PracticeAreaNames.ToList();
                        return View(model);
                    }

                    string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
                    string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "dist/img", fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.ImageFile.CopyTo(stream);
                    }

                    model.Img = fileName;
                }

                _context.PracticeAreas.Add(model);
                _context.SaveChanges();
                ViewBag.Settings = _context.Settings.ToList();
                ViewBag.PracticeAreaName = _context.PracticeAreaNames.ToList();
                return RedirectToAction("Index");
            }
            ViewBag.Settings = _context.Settings.ToList();
            ViewBag.PracticeAreaName = _context.PracticeAreaNames.ToList();
            return View(model);
        }

        public IActionResult Update(int? pracId)
        {
            if (pracId == null && pracId <= 0)
            {
                ViewBag.Settings = _context.Settings.ToList();
                ViewBag.PracticeAreaName = _context.PracticeAreaNames.ToList();
                return NotFound();
            }

            PracticeArea practice = _context.PracticeAreas.Find(pracId);
            ViewBag.Settings = _context.Settings.ToList();
            ViewBag.PracticeAreaName = _context.PracticeAreaNames.ToList();
            return View(practice);
        }

        [HttpPost]
        public IActionResult Update(PracticeArea model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {
                    if (!(model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif" || model.ImageFile.ContentType == "image/jpg"))
                    {
                        ModelState.AddModelError("", "You can only upload jpeg, png, and gif");
                        ViewBag.Settings = _context.Settings.ToList();
                        ViewBag.PracticeAreaName = _context.PracticeAreaNames.ToList();
                        return View(model);
                    }

                    if (model.ImageFile.Length > 2097152)
                    {
                        ModelState.AddModelError("", "You can only upload max 2 Mb size images");
                        ViewBag.Settings = _context.Settings.ToList();
                        ViewBag.PracticeAreaName = _context.PracticeAreaNames.ToList();
                        return View(model);
                    }

                    string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
                    string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "dist/img", fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.ImageFile.CopyTo(stream);
                    }

                    model.Img = fileName;
                }
                _context.PracticeAreas.Update(model);
                _context.SaveChanges();
                ViewBag.Settings = _context.Settings.ToList();
                ViewBag.PracticeAreaName = _context.PracticeAreaNames.ToList();
                return RedirectToAction("Index");
            }
            ViewBag.Settings = _context.Settings.ToList();
            ViewBag.PracticeAreaName = _context.PracticeAreaNames.ToList();
            return View(model);
        }

        public IActionResult Delete(int? pracId)
        {
            PracticeArea practice = _context.PracticeAreas.Find(pracId);
            _context.PracticeAreas.Remove(practice);
            _context.SaveChanges();
            ViewBag.Settings = _context.Settings.ToList();
            ViewBag.PracticeAreaName = _context.PracticeAreaNames.ToList();
            return RedirectToAction("Index");
        }
    }
}
