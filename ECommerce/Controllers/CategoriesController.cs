using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ECommerce.Areas.Identity.Data;
using ECommerce.Models;

namespace ECommerce.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ECommerceDbContext _context;

        public CategoriesController(ECommerceDbContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        

        

       

        
    }
}
