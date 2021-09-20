using Justica2.Data;
using Justica2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.ViewComponents
{
    public class VcTeam:ViewComponent
    {
        private readonly AppDbContext _context;

        public VcTeam(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            List<Team> team = _context.Teams.Include(g=>g.Position).Include(d=>d.TeamToSocials).ThenInclude(m=>m.TeamSocial).ToList();
            return View(team);
        }
    }
}
