using System.Diagnostics;
using FIAP_MVC.Data;
using FIAP_MVC.DTOs;
using Microsoft.AspNetCore.Mvc;
using FIAP_MVC.Models;

namespace FIAP_MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, DataContext dataContext)
        {
            _dataContext = dataContext;
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }


        //

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}