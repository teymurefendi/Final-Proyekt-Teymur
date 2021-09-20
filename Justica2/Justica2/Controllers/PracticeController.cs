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
    public class PracticeController : Controller
    {
        private readonly AppDbContext _context;

        public PracticeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Active = "Practice";
            //List <PracticeArea> practiceAreas = _context.PracticeAreas.ToList();
            VmPractice model = new VmPractice();
            model.practiceAreas = _context.PracticeAreas.Include(v=>v.PracticeAreaNames).ToList();            
            model.PracticeAreaNames = _context.PracticeAreaNames.ToList();
            return View(model);
        }
    }
}
