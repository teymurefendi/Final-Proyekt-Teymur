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
    public class NewsDetailController : Controller
    {
        private readonly AppDbContext _context;

        public NewsDetailController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.Active = "NewsDetail";
            VmNewsDetail model = new VmNewsDetail();
            model.News = await _context.News.Include(a => a.NewsNames).Include(j=>j.NewsToTags).ThenInclude(s=>s.Tag).ToListAsync();
            var newsnames = await _context.NewsNames.Where(n => n.Id == id).FirstOrDefaultAsync();
            if (newsnames == null)
                return NotFound();
            model.New = await _context.News.Include(n => n.NewsNames).Include(k=>k.NewsToTags).ThenInclude(w=>w.Tag).FirstOrDefaultAsync(n => n.Id == newsnames.NewsId);
            model.NewsNames = await _context.NewsNames.ToListAsync();
            return View(model);
        }

        
    }
}
