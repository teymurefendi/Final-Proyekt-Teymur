using Justica2.Data;
using Justica2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.ViewComponents
{
    public class VcYears:ViewComponent
    {
        private readonly AppDbContext _context;

        public VcYears(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            Experience experience = _context.Experiences.FirstOrDefault();
            return View(experience);
        }
    }
}
