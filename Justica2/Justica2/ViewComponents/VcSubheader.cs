using Justica2.Data;
using Justica2.Models;
using Justica2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.ViewComponents
{
    public class VcSubheader:ViewComponent
    {
        private readonly AppDbContext _context;

        public VcSubheader(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(string PageName)
        {
            Subheader subheader = _context.Subheaders.FirstOrDefault(p => p.PageName == PageName);
            return View(subheader);
        }
    }
}
