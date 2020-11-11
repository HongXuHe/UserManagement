using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserManagement.IRepository;
using UserManagement.UnitOfWok;
using UserManagement.Web.Models;

namespace UserManagement.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRepo _userRepo;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger,IUserRepo userRepo,IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _userRepo = userRepo;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var user = _unitOfWork.UserRepo.FindSingle(x => x.Email == "Matt@gmail.com");
            user.UserName = "matt";
            _unitOfWork.SaveChanges();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
