﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication14.Controllers
{
    public class PizzaController : Controller

    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
