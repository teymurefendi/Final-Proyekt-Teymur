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
    public class NewsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public NewsController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "News";
            List<News> News1 = _context.News.Include(t => t.NewsNames).Include(q=>q.Comments).Include(c => c.NewsToTags).ThenInclude(w=>w.Tag).ToList();

            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(News1.Count / dataPage);

            List<News> News2 = News1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = News1.Count;

            return View(News2);
        }

        public IActionResult Create()
        {
            ViewBag.NewsNames = _context.NewsNames.ToList();
            ViewBag.Comments = _context.Comments.ToList();
            ViewBag.Tag = _context.Tags.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(News model)
        {
            if (ModelState.IsValid)
            {
                List<NewsToTag> newTag = model.NewsToTags;
                if (!(model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif" || model.ImageFile.ContentType == "image/jpg"))
                {
                    ModelState.AddModelError("", "You can only upload jpeg, png, and gif");
                    ViewBag.Comments = _context.Comments.ToList();
                    ViewBag.NewsNames = _context.NewsNames.ToList();
                    return View(model);
                }

                if (model.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("", "You can only upload max 2 Mb size images");
                    ViewBag.Comments = _context.Comments.ToList();
                    ViewBag.NewsNames = _context.NewsNames.ToList();
                    return View(model);
                }

                string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
                string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "dist/img", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageFile.CopyTo(stream);
                }

                model.Img = fileName;
                model.CreatedDAte = DateTime.Now;
                model.NewsToTags = null;
                _context.News.Add(model);
                _context.SaveChanges();

                foreach (var item in newTag)
                {
                    if (item.TagId > 0)
                    {
                        NewsToTag newsToTag = new NewsToTag()
                        {
                            NewsId = model.Id,
                            TagId = item.TagId
                        };
                        _context.NewsToTags.Add(newsToTag);
                    }
                }

                _context.SaveChanges();


                return RedirectToAction("Index");
            }
            ViewBag.NewsNames = _context.NewsNames.ToList();
            ViewBag.Comments = _context.Comments.ToList();
            return View(model);
        }

        public IActionResult Update(int? NewsId)
        {
            if (NewsId == null && NewsId <= 0)
            {
                return NotFound();
            }

            ViewBag.NewsNames = _context.NewsNames.ToList();
            ViewBag.Comments = _context.Comments.ToList();
            ViewBag.Tag = _context.Tags.ToList();

            News News = _context.News
                                     .Include(p => p.NewsNames)
                                     .Include(s => s.NewsToTags).ThenInclude(ss => ss.Tag)
                                     .FirstOrDefault(t => t.Id == NewsId);

            return View(News);
        }

        [HttpPost]
        public IActionResult Update(News model)
        {
            if (ModelState.IsValid)
            {
                List<NewsToTag> newTag = model.NewsToTags;
                List<NewsToTag> oldTag = _context.NewsToTags.Where(s => s.NewsId == model.Id).ToList();

                if (model.ImageFile != null)
                {
                    if (!(model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif" || model.ImageFile.ContentType == "image/jpg"))
                    {
                        ModelState.AddModelError("", "You can only upload jpeg, png, and gif");
                        ViewBag.NewsNames = _context.NewsNames.ToList();
                        ViewBag.Comments = _context.Comments.ToList();
                        return View(model);
                    }

                    if (model.ImageFile.Length > 2097152)
                    {
                        ModelState.AddModelError("", "You can only upload max 2 Mb size images");
                        ViewBag.NewsNames = _context.NewsNames.ToList();
                        ViewBag.Comments = _context.Comments.ToList();
                        return View(model);
                    }

                    string oldFilePath = Path.Combine(_webHostEnvironment.WebRootPath, "dist/img", model.Img);
                    System.IO.File.Delete(oldFilePath);

                    string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
                    string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "dist/img", fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.ImageFile.CopyTo(stream);
                    }
                    model.Img = fileName;
                }


                model.NewsToTags = null;
                model.CreatedDAte = DateTime.Now;
                _context.News.Update(model);
                _context.SaveChanges();

                _context.NewsToTags.RemoveRange(oldTag);

                foreach (var item in newTag)
                {
                    if (item.TagId > 0)
                    {
                        NewsToTag social = new NewsToTag()
                        {
                            NewsId = model.Id,
                            TagId = item.TagId
                        };
                        _context.NewsToTags.Add(social);
                    }
                }

                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            ViewBag.NewsNames = _context.NewsNames.ToList();
            ViewBag.Comments = _context.Comments.ToList();
            return View(model);
        }

        public IActionResult Delete(int? NewsId)
        {
            News news = _context.News.Find(NewsId);
            _context.News.Remove(news);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public JsonResult GetTags()
        {
            List<Tag> tags = _context.Tags.ToList();
            return Json(tags);
        }
    }
}
