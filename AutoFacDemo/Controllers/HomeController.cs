using AutoFacDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoFacDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IAutoFacService autoFacService;

        public HomeController(IAutoFacService _autoFacService)
        {
            autoFacService = _autoFacService;
        }
        public string Index(string Name)
        {
            string str = autoFacService.getString();
            return "Hello " + Name + " Message: " + str;
        }
    }
}
