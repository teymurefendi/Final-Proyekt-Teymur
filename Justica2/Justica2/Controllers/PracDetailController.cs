using Justica2.Data;
using Justica2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Controllers
{
    public class PracDetailController : Controller
    {
        private readonly AppDbContext _context;

        public PracDetailController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int id)
        {
            
            ViewBag.Active = "PracDetail";
            VmPracDetail model = new VmPracDetail();
            model.practiceAreas = _context.PracticeAreas.Include(a=>a.PracticeAreaNames).ToList();
            var practiceAreaNames = await _context.PracticeAreaNames.Where(n => n.Id == id).FirstOrDefaultAsync();
            if (practiceAreaNames == null)
                return NotFound();
            model.Area = await _context.PracticeAreas.Include(n => n.PracticeAreaNames).FirstOrDefaultAsync(n => n.Id == practiceAreaNames.PracticeAreaId);
            model.PracticeAreaNames = _context.PracticeAreaNames.ToList();
            model.Settings = _context.Settings.FirstOrDefault();
            model.Forms = _context.Forms.ToList();
            return View(model);
        }
    }
}
