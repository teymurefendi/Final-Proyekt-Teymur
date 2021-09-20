using Justica2.Data;
using Justica2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;

        public TeamController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Active = "Team";
            List<Team> teams = _context.Teams.Include(t => t.Position).Include(v => v.TeamToSocials).ThenInclude(l => l.TeamSocial).ToList();
            return View(teams);
        }
    }
}
