using Justica2.Data;
using Justica2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "SuperAdmin,Admin")]
    public class SubscribeController : Controller
    {
        private readonly AppDbContext _context;

        public SubscribeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "Subscribe";
            List<Subscribe> Subscribes1 = _context.Subscribes.ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(Subscribes1.Count / dataPage);

            List<Subscribe> Subscribes2 = Subscribes1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = Subscribes1.Count;
            return View(Subscribes2);
        }        

        public IActionResult Delete(int? SubscribeId)
        {
            Subscribe Subscribe = _context.Subscribes.Find(SubscribeId);
            _context.Subscribes.Remove(Subscribe);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
