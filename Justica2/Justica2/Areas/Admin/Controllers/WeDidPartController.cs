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
    public class WeDidPartController : Controller
    {
        private readonly AppDbContext _context;

        public WeDidPartController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "WhatWeDid";
            List<WeDidPart> we1 = _context.WeDidParts.Include(s => s.WhatWeDid).ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(we1.Count / dataPage);

            List<WeDidPart> we2 = we1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = we1.Count;
            return View(we2);
        }

        public IActionResult Create()
        {
            ViewBag.WhatWeDid = _context.WhatWeDids.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(WeDidPart model)
        {
            if (ModelState.IsValid)
            {
                _context.WeDidParts.Add(model);
                _context.SaveChanges();
                ViewBag.WhatWeDid = _context.WhatWeDids.ToList();
                return RedirectToAction("Index");
            }
            ViewBag.WhatWeDid = _context.WhatWeDids.ToList();
            return View(model);
        }

        public IActionResult Update(int? weId)
        {
            if (weId == null && weId <= 0)
            {
                ViewBag.WhatWeDid = _context.WhatWeDids.ToList();
                return NotFound();
            }
            WeDidPart weDidPart = _context.WeDidParts.Find(weId);
            ViewBag.WhatWeDid = _context.WhatWeDids.ToList();
            return View(weDidPart);
        }

        [HttpPost]
        public IActionResult Update(WeDidPart model)
        {
            if (ModelState.IsValid)
            {
                _context.WeDidParts.Update(model);
                _context.SaveChanges();
                ViewBag.WhatWeDid = _context.WhatWeDids.ToList();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Duzgun duzelt!");
            ViewBag.WhatWeDid = _context.WhatWeDids.ToList();
            return View();

        }

        public IActionResult Delete(int? weId)
        {
            WeDidPart weDidPart = _context.WeDidParts.Find(weId);
            _context.WeDidParts.Remove(weDidPart);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
