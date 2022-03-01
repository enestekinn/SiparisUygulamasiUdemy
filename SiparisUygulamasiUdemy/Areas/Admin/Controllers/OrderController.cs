using Microsoft.AspNetCore.Mvc;
using SiparisUygulamasiUdemy.Data.Repository.IRepository;
using SiparisUygulamasiUdemy.Models.ViewModels;

namespace SiparisUygulamasiUdemy.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderVM OrderVM { get; set; }

        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var orderList = _unitOfWork.OrderProduct.GetAll(x=> x.OrderStatus != "Teslim Edildi");
            return View();
        }
    }
}
