using Microsoft.AspNetCore.Mvc;
using SiparisUygulamasiUdemy.Data.Repository.IRepository;
using SiparisUygulamasiUdemy.Models;

namespace SiparisUygulamasiUdemy.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

               
        }
        public IActionResult Index()
        {
            IEnumerable<Category> categoriesList = _unitOfWork.Category.GetAll();
            return View(categoriesList);
        }

        // tanimlama yapilmazsa actionlar get olarak gorulur.
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Add(category);
                _unitOfWork.Save();
                return RedirectToAction("Index");
                    
            }
            return View(category);  

        }
        public IActionResult Edit(int id)
        {
            if(id == null || id <= 0)
            {
                return NotFound();
            }
            var category = _unitOfWork.Category.GetFirstOrDefault(x => x.Id == id);
            if(category == null)
            {
                return NotFound();
            }

            return View();
        }
        // post isleminde form tagi kullanilir.
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Update(category);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View(category);
        }
        public IActionResult Delete(int id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }
            var category = _unitOfWork.Category.GetFirstOrDefault(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            _unitOfWork.Category.Remove(category);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
