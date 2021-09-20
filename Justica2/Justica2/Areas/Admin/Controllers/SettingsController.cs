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
    public class SettingsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SettingsController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "Settings";
            List<Settings> set1 = _context.Settings.Include(w=>w.SettingSocials).ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(set1.Count / dataPage);

            List<Settings> set2 = set1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = set1.Count;
            return View(set2);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Settings model)
        {
            if (ModelState.IsValid)
            {
                if (!(_context.Settings.Any(d=>d.Id>0)))
                {
                    if (model.ImageFile1 != null && model.ImageFile2 != null)
                    {
                        if (!(model.ImageFile1.ContentType == "image/png" || model.ImageFile1.ContentType == "image/jpeg" || model.ImageFile1.ContentType == "image/gif" || model.ImageFile1.ContentType == "image/jpg" || model.ImageFile2.ContentType == "image/png" || model.ImageFile2.ContentType == "image/jpeg" || model.ImageFile2.ContentType == "image/gif" || model.ImageFile2.ContentType == "image/jpg"))
                        {
                            ModelState.AddModelError("", "You can only upload jpeg, png, and gif");
                            return View(model);
                        }

                        if (model.ImageFile1.Length > 2097152 && model.ImageFile2.Length > 2097152)
                        {
                            ModelState.AddModelError("", "You can only upload max 2 Mb size images");
                            return View(model);
                        }

                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile1.FileName;
                        string fileName1 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile2.FileName;
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "dist/img", fileName, fileName1);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile1.CopyTo(stream);
                            model.ImageFile2.CopyTo(stream);
                        }

                        model.Icon1 = fileName;
                        model.Icon2 = fileName;
                    }

                    _context.Settings.Add(model);
                    _context.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "yalniz 1 dene setting duzeltmek olar");
                }
            }
            return View(model);
        }

        public IActionResult Update(int? SettingsId)
        {
            if (SettingsId == null && SettingsId <= 0)
            {
                return NotFound();
            }

            Settings Settings = _context.Settings.Find(SettingsId);

            return View(Settings);
        }

        [HttpPost]
        public IActionResult Update(Settings model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile1 != null && model.ImageFile2 != null)
                {
                    if (!(model.ImageFile1.ContentType == "image/png" || model.ImageFile1.ContentType == "image/jpeg" || model.ImageFile1.ContentType == "image/gif" || model.ImageFile1.ContentType == "image/jpg" || model.ImageFile2.ContentType == "image/png" || model.ImageFile2.ContentType == "image/jpeg" || model.ImageFile2.ContentType == "image/gif" || model.ImageFile2.ContentType == "image/jpg"))
                    {
                        ModelState.AddModelError("", "You can only upload jpeg, png, and gif");
                        return View(model);
                    }

                    if (model.ImageFile1.Length > 2097152 && model.ImageFile2.Length > 2097152)
                    {
                        ModelState.AddModelError("", "You can only upload max 2 Mb size images");
                        return View(model);
                    }

                    string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile1.FileName;
                    string fileName1 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile2.FileName;
                    string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "dist/img", fileName, fileName1);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.ImageFile1.CopyTo(stream);
                        model.ImageFile2.CopyTo(stream);
                    }

                    model.Icon1 = fileName;
                    model.Icon2 = fileName;
                }
                _context.Settings.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int? SettingsId)
        {
            Settings Settings = _context.Settings.Find(SettingsId);
            _context.Settings.Remove(Settings);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
