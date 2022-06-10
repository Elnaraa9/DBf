using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class SliderController : Controller
    {
        private AppDbContext _db { get; }
        private IWebHostEnvironment _env { get; }
        public SliderController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.Slides);
        }
        public async Task<IActionResult> Create(Slide slide)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!slide.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Max size of image not be less than 200kb");
                return View();
            }
            if (!slide.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Type of file must be image");
                return View();
            }
           
            slide.Url =await slide.Photo.SaveFileAsync(_env.WebRootPath,"img");
            await _db.Slides.AddAsync(slide);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();
            var slider = _db.Slides.Find(id);
            if (slider == null) return NotFound();
           var path= Helper.GetPath(_env.WebRootPath, "img", slider.Url);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _db.Slides.Remove(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
