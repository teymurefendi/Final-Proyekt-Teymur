using Justica2.Data;
using Justica2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Active = "Contact";

            VmContact model = new VmContact();
            model.Form = _context.Forms.FirstOrDefault();
            model.Offices = _context.Offices.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Message(VmContact model1)
        {
            if (ModelState.IsValid)
            {
                model1.Form.CreatedDate = DateTime.Now;
                _context.Forms.Add(model1.Form);
                _context.SaveChanges();

            }

            return RedirectToAction("Index", "Contact");
        }
    }
}
