﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppWeb_MVC.Controllers
{
    public class EquipmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}