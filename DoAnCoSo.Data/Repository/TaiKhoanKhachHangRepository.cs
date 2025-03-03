﻿using DoAnCoSo.Data.ModelHelper;
using DoAnCoSo.DTOs;
using DoAnCoSo.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCoSo.Data.Repository
{
	public class TaiKhoanKhachHangRepository : RepositoryBase
	{
		private readonly ServiceBase serviceBase;
		public TaiKhoanKhachHangRepository() : base()
		{
			serviceBase = new ServiceBase();
		}
		public TaiKhoanKhachHangRepository(DoAnCoSoDbContext _db) : base(_db)
		{
			serviceBase = new ServiceBase();
		}

		public async Task<bool> TaoMoiTaiKhoan(DangKiClientModel model)
		{
			try
			{
				ThongTinKhachHang thongTinKhachHang = serviceBase.CastTo<ThongTinKhachHang>(model);
				thongTinKhachHang.NgayTaoTaiKhoan = DateTime.Now;
				await db.ThongTinKhachHangs.AddAsync(thongTinKhachHang);
				await db.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				Logging.Logging.Write(ex.Message);
				return false;
			}
		}

		public async Task<List<string>> GetAllEmail()
		{
			var data = await db.ThongTinKhachHangs.Select(x => x.Email)
				.ToListAsync();
			return data;
		}

		public async Task<bool> DangNhap(string email, string password)
		{
			return await db.ThongTinKhachHangs.AnyAsync(x => x.Email == email && x.MatKhau == password);
		}

		public async Task<ThongTinKhachHang> GetKhachHang(string email)
		{
			return await db.ThongTinKhachHangs.SingleOrDefaultAsync(x => x.Email == email);
		}

		public async Task<ChiTietTaiKhoanKhachHangClientModel> ChiTietTaiKhoanKhachHang(string email)
		{
			var taiKhoanKhachHang = await db.ThongTinKhachHangs
				.Where(x => x.Email == email)
				.Select(x => new ChiTietTaiKhoanKhachHangClientModel()
				{
					Id = x.Id,
					HoTenKhachHang = x.TenKhachHang,
					Email = x.Email,
					SoDienThoai = x.SoDienThoai,
					NgayTaoTaiKhoan = x.NgayTaoTaiKhoan,
					DanhSachDonDatHang = db.DonDatHangs.Where(x => x.Email == x.Email).OrderByDescending(x => x.Id).Take(6).ToList()
				})
				.SingleOrDefaultAsync();
			if (taiKhoanKhachHang != null)
			{
				return taiKhoanKhachHang;
			}
			else
			{
				return null;
			}
		}
	}
}
