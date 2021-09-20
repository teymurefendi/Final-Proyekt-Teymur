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
    public class WhatWeDidController : Controller
    {
        private readonly AppDbContext _context;

        public WhatWeDidController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "WhatWeDid";
            List<WhatWeDid> WhatWeDids1 = _context.WhatWeDids.Include(f => f.WeDidParts).ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(WhatWeDids1.Count / dataPage);

            List<WhatWeDid> WhatWeDids2 = WhatWeDids1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = WhatWeDids1.Count;
            return View(WhatWeDids2);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(WhatWeDid model)
        {
            if (ModelState.IsValid)
            {
                if (!(_context.WhatWeDids.Any(d => d.Id > 0)))
                {
                    _context.WhatWeDids.Add(model);
                    _context.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "yalniz 1 dene duzeltmek olar");
                }
            }
            return View(model);
        }

        public IActionResult Update(int? whatId)
        {
            if (whatId == null && whatId <= 0)
            {
                return NotFound();
            }
            WhatWeDid WhatWeDid = _context.WhatWeDids.Find(whatId);
            return View(WhatWeDid);
        }

        [HttpPost]
        public IActionResult Update(WhatWeDid model)
        {
            if (ModelState.IsValid)
            {
                _context.WhatWeDids.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Duzgun duzelt!");
            return View();

        }

        public IActionResult Delete(int? whatId)
        {
            WhatWeDid WhatWeDid = _context.WhatWeDids.Find(whatId);
            _context.WhatWeDids.Remove(WhatWeDid);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
