using Justica2.Data;
using Justica2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.ViewComponents
{
    public class VcHeader: ViewComponent
    {
        private readonly AppDbContext _context;

        public VcHeader(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            VmHeader model = new VmHeader();
            model.Settings = _context.Settings.FirstOrDefault();
            model.SettingSocials = _context.SettingSocials.ToList();
            model.PracticeAreas = _context.PracticeAreas.ToList();
            return View(model);
        }
    }
}
