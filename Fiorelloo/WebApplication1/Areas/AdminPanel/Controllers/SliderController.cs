using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class SliderController : Controller
    {
        private AppDbContext _db { get; }
        private IWebHostEnvironment _env { get; }
        public SliderController(IWebHostEnvironment env)
        {
            _env = env;
        }
        public SliderController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Slides);
        }
        public IActionResult Create(Slide slide)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (slide.Photo.Length / 1024 > 200)
            {
                ModelState.AddModelError("Photo", "Max size of image not be less than 200kb");
            }
            if (!slide.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Type of file must be image");
                return View();
            }
            var fileName = Guid.NewGuid().ToString() + slide.Photo.FileName;

            using (FileStream fileStream = new FileStream(@"C:\Users\Hp\OneDrive\İş masası\DBf\Fiorelloo\WebApplication1\wwwroot\img\" + slide.Photo.FileName, FileMode.Create))
            {
                slide.Photo.CopyTo(fileStream);
            }
            return Json(slide.Photo.FileName);
        }
    }
}
