﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSo.DTOs
{
	public class MauSac
	{
		[Key]
		public int Id { get; set; }
		public string MaMau { get; set; }
		public string MaCSS { get; set; }
	}
}
