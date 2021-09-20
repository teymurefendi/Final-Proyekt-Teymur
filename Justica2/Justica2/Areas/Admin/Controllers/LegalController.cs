using Justica2.Data;
using Justica2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "SuperAdmin,Admin")]
    public class LegalController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public LegalController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "Legal";
            List<Legal> legal1 = _context.Legals.ToList();
            decimal dataPage = 3;
            decimal pageCount = Math.Ceiling(legal1.Count / dataPage);

            List<Legal> legal2 = legal1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = legal1.Count;
            return View(legal2);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Legal model)
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

                    model.Img1 = fileName;
                    model.Img2 = fileName;
                }

                _context.Legals.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Update(int? legalId)
        {
            if (legalId == null && legalId <= 0)
            {
                return NotFound();
            }

            Legal legal = _context.Legals.Find(legalId);

            return View(legal);
        }

        [HttpPost]
        public IActionResult Update(Legal model)
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

                    model.Img1 = fileName;
                    model.Img2 = fileName;
                }
                _context.Legals.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int? legalId)
        {
            Legal legal = _context.Legals.Find(legalId);
            _context.Legals.Remove(legal);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
