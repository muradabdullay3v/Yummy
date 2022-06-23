using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yummy.DAL;
using Yummy.Helpers;
using Yummy.Models;

namespace Yummy.Areas.YummyAdmin.Controllers
{
     [Area("YummyAdmin")]
    public class ProductsController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }

        public ProductsController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (product.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo" , "Image's max size must be less than 200kb");
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
