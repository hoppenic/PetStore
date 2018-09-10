using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetStore.Models;

namespace PetStore.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //responds on GET /account/register

        public IActionResult Register()
        {
            return View();
        }

        //responds on POST /account/register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(string userName,string password)
        {
            return Ok();
        }


    }
}