﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GoInvoice.MobileAppService.Controllers
{
    public class NotesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}