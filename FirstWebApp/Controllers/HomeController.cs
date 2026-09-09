using Domains.DTOs; 
using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Diagnostics; 


namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;

        public HomeController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            var userId = Guid.Parse("E48B11A8-FA0A-412E-8A7F-D7DF4801A54F");


            var userService = new UserService();
            userService.Add(new AddUserRequest()
            {
                Id = userId,
                FullName = "Osama",
                EmailAddress = "oo@oo.com",
                Address = "Amman",
                Password = "102030"
            });



            var res = userService.GetUserInfo(userId);



            var x = userService.GetUserInfo();

            Console.WriteLine(x.Item1);
            Console.WriteLine(x.Item2);



            return View();
        }

        public IActionResult Index2()
        {
            var userId = Guid.Parse("E48B11A8-FA0A-412E-8A7F-D7DF4801A54F");


            var userService = new UserService();
            userService.Add(new AddUserRequest()
            {
                Id = userId,
                FullName = "Osama",
                EmailAddress = "oo@oo.com",
                Address = "Amman",
                Password = "102030"
            });



            var res = userService.GetUserInfo(userId);



            var x = userService.GetUserInfo();

            Console.WriteLine(x.Item1);
            Console.WriteLine(x.Item2);


            return View();
        }

        public IActionResult Index3()
        {
            var userId = Guid.Parse("E48B11A8-FA0A-412E-8A7F-D7DF4801A54F");


            var userService = new UserService();
            userService.Add(new AddUserRequest()
            {
                Id = userId,
                FullName = "Osama",
                EmailAddress = "oo@oo.com",
                Address = "Amman",
                Password = "102030"
            });



            var res = userService.GetUserInfo(userId);



            var x = userService.GetUserInfo();

            Console.WriteLine(x.Item1);
            Console.WriteLine(x.Item2);


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
