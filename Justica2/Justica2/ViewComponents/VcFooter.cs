using Justica2.Data;
using Justica2.Models;
using Justica2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.ViewComponents
{
    public class VcFooter: ViewComponent
    {
        private readonly AppDbContext _context;

        public VcFooter(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            VmFooter model = new VmFooter();
            model.Settings = _context.Settings.FirstOrDefault();
            model.SettingSocials = _context.SettingSocials.ToList();
            model.PracticeAreas = _context.PracticeAreas.ToList();
            model.Subscribe1 = _context.Subscribes.FirstOrDefault();
            return View(model);
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Subscribe model1)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (!_context.Subscribes.Any(v => v.Email == model1.Email))
        //        {
        //            model1.CreatedDate = DateTime.Now;
        //            _context.Subscribes.Add(model1);
        //            _context.SaveChanges();
        //        }
        //        ModelState.AddModelError("", "The same Email");
        //    }
        //    var Subscribe1 = _context.Subscribes.FirstOrDefault(a => a.Email == model1.Email);
        //    return View(model1);
        //}

        //public IActionResult Subscribe(Subscribe model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (!_context.Subscribes.Any(v => v.Email == model.Email))
        //        {
        //            model.CreatedDate = DateTime.Now;
        //            _context.Subscribes.Add(model);
        //            _context.SaveChanges();
        //        }
        //        ModelState.AddModelError("", "The same Email");
        //    }
        //    return View(model);
        //}
    }
}
