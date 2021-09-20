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
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TeamController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "Team";
            List<Team> Team1 = _context.Teams.Include(t => t.Position).Include(c => c.TeamToSocials).ThenInclude(w => w.TeamSocial).ToList();

            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(Team1.Count / dataPage);

            List<Team> Team2 = Team1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = Team1.Count;

            return View(Team2);
        }

        public IActionResult Create()
        {
            ViewBag.Position = _context.Positions.ToList();
            ViewBag.TeamSocial = _context.TeamSocials.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Team model)
        {
            if (ModelState.IsValid)
            {
                List<TeamToSocial> newTeamSocial = model.TeamToSocials;
                if (!(model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif" || model.ImageFile.ContentType == "image/jpg"))
                {
                    ModelState.AddModelError("", "You can only upload jpeg, png, and gif");
                    ViewBag.Position = _context.Positions.ToList();
                    ViewBag.TeamSocial = _context.TeamSocials.ToList();
                    return View(model);
                }

                if (model.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("", "You can only upload max 2 Mb size images");
                    ViewBag.Position = _context.Positions.ToList();
                    ViewBag.TeamSocial = _context.TeamSocials.ToList();
                    return View(model);
                }

                string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
                string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "dist/img", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageFile.CopyTo(stream);
                }

                model.Img = fileName;
                
                model.TeamToSocials = null;
                _context.Teams.Add(model);
                _context.SaveChanges();

                foreach (var item in newTeamSocial)
                {
                    if (item.TeamSocialId > 0 && item.Link != null)
                    {
                        TeamToSocial teamToSocial = new TeamToSocial()
                        {
                            TeamId = model.Id,
                            TeamSocialId = item.TeamSocialId,
                            Link = item.Link
                        };
                        _context.TeamToSocials.Add(teamToSocial);
                    }
                }

                _context.SaveChanges();


                return RedirectToAction("Index");
            }
            ViewBag.Position = _context.Positions.ToList();
            ViewBag.TeamSocial = _context.TeamSocials.ToList();
            return View(model);
        }

        public IActionResult Update(int? TeamId)
        {
            if (TeamId == null && TeamId <= 0)
            {
                return NotFound();
            }

            ViewBag.Position = _context.Positions.ToList();
            ViewBag.TeamSocial = _context.TeamSocials.ToList();

            Team Team = _context.Teams
                                     .Include(p => p.Position)
                                     .Include(s => s.TeamToSocials).ThenInclude(ss => ss.TeamSocial)
                                     .FirstOrDefault(t => t.Id == TeamId);

            return View(Team);
        }

        [HttpPost]
        public IActionResult Update(Team model)
        {
            if (ModelState.IsValid)
            {
                List<TeamToSocial> newTeamSocial = model.TeamToSocials;
                List<TeamToSocial> oldTeamSocial = _context.TeamToSocials.Where(s => s.TeamId == model.Id).ToList();

                if (model.ImageFile != null)
                {
                    if (!(model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif" || model.ImageFile.ContentType == "image/jpg"))
                    {
                        ModelState.AddModelError("", "You can only upload jpeg, png, and gif");
                        ViewBag.Position = _context.Positions.ToList();
                        ViewBag.TeamSocial = _context.TeamSocials.ToList();
                        return View(model);
                    }

                    if (model.ImageFile.Length > 2097152)
                    {
                        ModelState.AddModelError("", "You can only upload max 2 Mb size images");
                        ViewBag.Position = _context.Positions.ToList();
                        ViewBag.TeamSocial = _context.TeamSocials.ToList();
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


                model.TeamToSocials = null;
                _context.Teams.Update(model);
                _context.SaveChanges();

                _context.TeamToSocials.RemoveRange(oldTeamSocial);

                foreach (var item in newTeamSocial)
                {
                    if (item.TeamSocialId > 0 && item.Link != null)
                    {
                        TeamToSocial social = new TeamToSocial()
                        {
                            TeamId = model.Id,
                            TeamSocialId = item.TeamSocialId,
                            Link = item.Link
                        };
                        _context.TeamToSocials.Add(social);
                    }
                }

                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            ViewBag.Position = _context.Positions.ToList();
            ViewBag.TeamSocial = _context.TeamSocials.ToList();
            return View(model);
        }

        public IActionResult Delete(int? TeamId)
        {
            Team Team = _context.Teams.Find(TeamId);
            _context.Teams.Remove(Team);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public JsonResult GetSocials()
        {
            List<TeamSocial> socials = _context.TeamSocials.ToList();
            return Json(socials);
        }
    }
}
