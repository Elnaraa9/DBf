using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.ViewModels.Categories;

namespace WebApplication1.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]

    public class CategoryController : Controller
    {

        private AppDbContext _db { get; }
        private IEnumerable<Category> categories { get; set; }
        public CategoryController(AppDbContext db)
        {
            _db = db;
            categories = _db.Categories.Where(ct => !ct.IsDeleted);

        }
        public IActionResult Index()
        {
            return View(categories);
        }
       
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryCreateVM category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool isExist = categories.Where(ct => !ct.IsDeleted).Any(c=>c.Name.ToLower()==category.Name.ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Name", $"{ category.Name} is exist");
                return View();
            }
            //foreach (var ct in categories)
            //{
            //    if (ct.Name.ToLower() == category.Name.ToLower())
            //    {
            //        isExist = true;break;
            //    }
            //}
            Category newCategory = new Category
            {
                Name=category.Name
            };
           await  _db.Categories.AddAsync(newCategory);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            if (id == null)
                return BadRequest();

            Category category = _db.Categories.Where(c=>!c.IsDeleted).FirstOrDefault(category => category.Id == id);
            if(category==null)
                return NotFound();

            return View(category);
;        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Category category)
        {
            if (id == null)
                return BadRequest();
            Category categoryDb = _db.Categories
                .Where(c => !c.IsDeleted).FirstOrDefault(category => category.Id == id);
            if (categoryDb == null)
                return NotFound();
            //if (category.Name.ToLower() == categoryDb.Name.ToLower())
            //    return RedirectToAction(nameof(Index));


            bool isExist = categories.Where(c => !c.IsDeleted)
                .Any(c => c.Name.ToLower() == category.Name.ToLower()&& c.Id!=categoryDb.Id);
            if (isExist)
            {
                ModelState.AddModelError("Name", $"{ category.Name} is exist");
                return View();
            }
            categoryDb.Name = category.Name;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            Category categoryDb = _db.Categories.Where(c => !c.IsDeleted).FirstOrDefault(category => category.Id == id);
            if (categoryDb == null)
                return NotFound();
            //_db.Categories.Remove(categoryDb);
            categoryDb.IsDeleted = true;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
