﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnCoSo.Areas.Admin.Controllers
{
	public class LienHeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
