using Justica2.Data;
using Justica2.Models;
using Justica2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Controllers
{
    public class NewsController : Controller
    {
        private readonly AppDbContext _context;

        public NewsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            ViewBag.Active = "News";
            //var News1 = await _context.News.Where(j => j.Id == Id).FirstOrDefaultAsync();
            //if (News1 == null)
            //    return NotFound();
            //News1.CreatedDAte.Month.ToString("MMM");
            VmNews model = new VmNews();
            model.News = await _context.News.ToListAsync();
            
            decimal dataPage = 6;
            decimal pageCount = Math.Ceiling(model.News.Count / dataPage);
            model.NewsNames = await _context.NewsNames.ToListAsync();
            model.News2 = model.News.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();            
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = model.News.Count;
            return View(model);
        }
    }
}
