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
    public class FormController : Controller
    {
        private readonly AppDbContext _context;

        public FormController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "Form";
            List<Form> Forms1 = _context.Forms.ToList();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(Forms1.Count / dataPage);

            List<Form> Forms2 = Forms1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = Forms1.Count;
            return View(Forms2);
        }       

        public IActionResult Delete(int? FormId)
        {
            Form Form = _context.Forms.Find(FormId);
            _context.Forms.Remove(Form);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
