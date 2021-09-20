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
    public class PositionController : Controller
    {
        private readonly AppDbContext _context;

        public PositionController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "Team";
            List<Position> Positions1 = _context.Positions.Include(f => f.Teams).ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(Positions1.Count / dataPage);

            List<Position> Positions2 = Positions1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = Positions1.Count;
            return View(Positions2);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Position model)
        {
            if (ModelState.IsValid)
            {
                _context.Positions.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int? PositionId)
        {
            if (PositionId == null && PositionId <= 0)
            {
                return NotFound();
            }
            Position Position = _context.Positions.Find(PositionId);
            return View(Position);
        }

        [HttpPost]
        public IActionResult Update(Position model)
        {
            if (ModelState.IsValid)
            {
                _context.Positions.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Duzgun duzelt!");
            return View();

        }

        public IActionResult Delete(int? PositionId)
        {
            Position Position = _context.Positions.Find(PositionId);
            _context.Positions.Remove(Position);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
