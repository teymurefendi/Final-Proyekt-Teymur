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
    public class TeamSocialController : Controller
    {
        private readonly AppDbContext _context;

        public TeamSocialController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "Team";
            List<TeamSocial> TeamSocials1 = _context.TeamSocials.Include(f => f.TeamToSocials).ThenInclude(x=>x.Team).ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(TeamSocials1.Count / dataPage);

            List<TeamSocial> TeamSocials2 = TeamSocials1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = TeamSocials1.Count;
            return View(TeamSocials2);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(TeamSocial model)
        {
            if (ModelState.IsValid)
            {
                _context.TeamSocials.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int? TeamSocialId)
        {
            if (TeamSocialId == null && TeamSocialId <= 0)
            {
                return NotFound();
            }
            TeamSocial TeamSocial = _context.TeamSocials.Find(TeamSocialId);
            return View(TeamSocial);
        }

        [HttpPost]
        public IActionResult Update(TeamSocial model)
        {
            if (ModelState.IsValid)
            {
                _context.TeamSocials.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Duzgun duzelt!");
            return View();

        }

        public IActionResult Delete(int? TeamSocialId)
        {
            TeamSocial TeamSocial = _context.TeamSocials.Find(TeamSocialId);
            _context.TeamSocials.Remove(TeamSocial);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
