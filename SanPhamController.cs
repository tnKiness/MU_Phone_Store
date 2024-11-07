using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DoAn_FW.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace Web_ProjectFrameWork.Controllers
{
    public class SanPhamController : Controller
    {
        //Kiểm tra đăng nhập và lấy thông tin khách hàng gán vào ViewBag.KH
        public void DataKH()
        {
            var KH = new KhachHang();
            if (HttpContext.Session.GetString("KH") != null)
            {
                KH = JsonConvert.DeserializeObject<KhachHang>(HttpContext.Session.GetString("KH"));
            }
            this.ViewBag.KH = KH;
        }
        //Kiểm tra đăng nhập và lấy thông tin giỏ hàng của khách hàng gán vào ViewBag.Cart
        public void DataCart()
        {
            var KH = new KhachHang();
            if (HttpContext.Session.GetString("KH") != null)
            {
                KH = JsonConvert.DeserializeObject<KhachHang>(HttpContext.Session.GetString("KH"));
            }
            var context = new GioHang();
            var cart = context.ListGioHang(KH.MaKH);
            this.ViewBag.cart = cart;
        }

        public IActionResult DanhSachSP(int pg = 1)
        {
            var context = new SanPhamContext();
            List<object> list = context.ListSPMoiNhat();
            int pageSize = 6;
            if (pg < 1) pg = 1;
            int recsCount = list.Count();
            var pager = new Pager(recsCount, pg, pageSize);

            int recSkip = (pg - 1) * pageSize;

            var data = list.Skip(recSkip).Take(pager.PageSize).ToList();

            this.ViewBag.Pager = pager;

            ViewData["list"] = data;
            ViewData["ListLoaiSP"] = context.ListLoaiSP();
            return View();
        }

        [HttpGet]
        public IActionResult Products(
            [FromQuery] List<string> MaLoaiSP,
            [FromQuery] List<string> Ram,
            [FromQuery] List<string> Memory,
            [FromQuery] List<string> ScreenSize,
            [FromQuery] List<string> MaTH, 
            [FromQuery] string search,
            [FromQuery] string sortOrder,
            int pg = 1)
        {
            DataKH();
            DataCart();
            var context = new SanPhamContext();

            var query = context.BuildFilterQuery(out var parameters, MaLoaiSP, Ram, Memory, ScreenSize, MaTH, search, sortOrder);

            int pageSize = 9;
            List<object> list;

            list = context.FetchFilteredProducts(query, parameters);

            if (pg < 1) pg = 1;
            int recsCount = list.Count();
            var pager = new Pager(recsCount, pg, pageSize);

            int recSkip = (pg - 1) * pageSize;

            var data = list.Skip(recSkip).Take(pager.PageSize).ToList();

            this.ViewBag.Pager = pager;

            ViewData["list"] = data;
            ViewData["ListLoaiSP"] = context.ListLoaiSP();
            ViewData["ListHang"] = context.ListHang();
            ViewData["ListRam"] = context.ListRam();
            ViewData["ListMemory"] = context.ListMemory();
            ViewData["ListManHinh"] = context.ListManHinh();
            return View();
        }

        [HttpGet]
        public IActionResult ChiTietSP(int t, int l)
        {
            DataKH();
            DataCart();
            var context = new SanPhamContext();
            ViewData["CTSP"] = context.ChiTietSP(t);
            ViewData["ListDT"] = context.FilterSanPham(l, t);
            ViewData["ListBL"] = context.BinhLuans(t);
            ViewData["ListPK"] = context.FilterSanPham(3); //"Tạo một list phụ kiện có thể tìm thấy được với MaLoaiSP = 3"
            return View();
        }

        /*
        public IActionResult FilterProducts(
        [FromQuery] List<string> LoaiSP,
        [FromQuery] List<string> Ram,
        [FromQuery] List<string> Memory,
        [FromQuery] List<string> ScreenSize,
        [FromQuery] List<string> Hang,
        int pg = 1)
        {
            var context = new SanPhamContext();
            var query = context.BuildFilterQuery(out var parameters, LoaiSP, Ram, Memory, ScreenSize, Hang);
            DataKH();
            DataCart();

            var list = context.FetchFilteredProducts(query, parameters);
            int pageSize = 8;
            int recsCount = list.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            var data = list.Skip((pg - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.Pager = pager;
            ViewData["list"] = data;
            ViewData["ListLoaiSP"] = new SanPhamContext().ListLoaiSP();
            return View(data);
        }
        */

        /*
        [HttpGet]
        public IActionResult DTDD(int pg = 1, int? math = null, string? search = null)
        {
            DataKH();
            DataCart();
            var context = new SanPhamContext();
            List<object> list;
            int pageSize = 8;
            if (math != null) {
                list = context.SPLocTheoHangSP(1,math);
            }
            else if(search != null)
            {
                list = context.SearchDT(search);
                pageSize = 100;
            }
            else
            {
                list = context.FilterSanPham(1);
            }
            if (pg < 1) pg = 1;
            int recsCount = list.Count();
            var pager = new Pager(recsCount, pg, pageSize);

            int recSkip = (pg - 1) * pageSize;

            var data = list.Skip(recSkip).Take(pager.PageSize).ToList();

            this.ViewBag.Pager = pager;

            ViewData["list"] = data;
            ViewData["math"] = math;
            ViewData["ListLoaiSP"] = context.ListLoaiSP();
            ViewData["ListHang"] = context.ListHang(1);
            ViewData["ListRam"] = context.ListRam(1);
            ViewData["ListMemory"] = context.ListMemory(1);
            ViewData["ListManHinh"] = context.ListManHinh(1);
            return View();
        }
        */

        /*
        private readonly string ConnectionString;

        // Khởi tạo controller với IConfiguration để lấy connection string
        public SanPhamController(IConfiguration configuration)
        {
            ConnectionString = "server=localhost;port=3306;database=website_dienthoai;uid=root;password=";
        }

        [HttpGet]
        public IActionResult FilterProducts(
            [FromQuery] List<string> LoaiSP,
            [FromQuery] List<string> Ram,
            [FromQuery] List<string> Memory,
            [FromQuery] List<string> ScreenSize,
            [FromQuery] List<string> Hang)
        {
            var query = "SELECT * FROM thongtinsp WHERE 1=1";
            var parameters = new List<MySqlParameter>();

            // Thêm điều kiện cho từng bộ lọc
            if (LoaiSP != null && LoaiSP.Count > 0)
            {
                query += " AND LoaiSP IN (" + string.Join(", ", LoaiSP.Select((x, index) => $"@LoaiSP{index}")) + ")";
                parameters.AddRange(LoaiSP.Select((x, index) => new MySqlParameter($"@LoaiSP{index}", x)));
            }

            if (Ram != null && Ram.Count > 0)
            {
                query += " AND Ram IN (" + string.Join(", ", Ram.Select((x, index) => $"@Ram{index}")) + ")";
                parameters.AddRange(Ram.Select((x, index) => new MySqlParameter($"@Ram{index}", x)));
            }

            if (Memory != null && Memory.Count > 0)
            {
                query += " AND BoNhoTrong IN (" + string.Join(", ", Memory.Select((x, index) => $"@Memory{index}")) + ")";
                parameters.AddRange(Memory.Select((x, index) => new MySqlParameter($"@Memory{index}", x)));
            }

            if (ScreenSize != null && ScreenSize.Count > 0)
            {
                query += " AND ManHinh IN (" + string.Join(", ", ScreenSize.Select((x, index) => $"@ScreenSize{index}")) + ")";
                parameters.AddRange(ScreenSize.Select((x, index) => new MySqlParameter($"@ScreenSize{index}", x)));
            }

            if (Hang != null && Hang.Count > 0)
            {
                query += " AND Hang IN (" + string.Join(", ", Hang.Select((x, index) => $"@Hang{index}")) + ")";
                parameters.AddRange(Hang.Select((x, index) => new MySqlParameter($"@Hang{index}", x)));
            }

            DataKH();
            DataCart();
            var context = new SanPhamContext();
            int pageSize = 8;


            var list = new List<SanPham>();
            using (var connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters.ToArray());
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new SanPham
                            {
                                Masp = reader.GetInt32("MaTTSP"),
                                Tensp = reader.GetString("TenSP"),
                                Maloaisp = reader.GetInt32("MaLoaiSP"),
                                Ram = reader.GetInt32("Ram"),
                                BoNhoTrong = reader.GetInt32("BoNhoTrong"),
                                KichThuocManHinh = reader.GetInt32("kichthuocmanhinh"),
                                Math = reader.GetInt32("MaTH")
                            };
                            list.Add(product);
                        }
                    }
                }
            }
            int pg = 1;
            if (pg < 1) pg = 1;
            int recsCount = list.Count();
            var pager = new Pager(recsCount, pg, pageSize);

            int recSkip = (pg - 1) * pageSize;

            var data = list.Skip(recSkip).Take(pager.PageSize).ToList();

            this.ViewBag.Pager = pager;

            ViewData["list"] = data;
            ViewData["ListLoaiSP"] = context.ListLoaiSP();
            ViewData["ListHang"] = context.ListHang(2);
            ViewData["ListRam"] = context.ListRam(2);
            ViewData["ListMemory"] = context.ListMemory(2);
            ViewData["ListManHinh"] = context.ListManHinh(2);
            return View("DTDD", list);
        }
        */
// Phụ kiện
        public IActionResult PhuKien(int pg = 1, int? math = null, string? search = null)
        {
            DataKH();
            DataCart();
            var context = new SanPhamContext();
            int pageSize = 8;
            List<object> list;

            if (math != null)
            {
                list = context.SPLocTheoHangSP(3, math); // Lọc theo hãng
            }
            else if (search != null)
            {
                list = context.SearchPK(search); // Tìm kiếm sản phẩm phụ kiện
                pageSize = 100;
            }
            else
            {
                list = context.FilterSanPham(3); // Lấy tất cả sản phẩm loại phụ kiện
            }

            if (pg < 1) pg = 1;
            int recsCount = list.Count();
            var pager = new Pager(recsCount, pg, pageSize);

            int recSkip = (pg - 1) * pageSize;

            var data = list.Skip(recSkip).Take(pager.PageSize).ToList();

            this.ViewBag.Pager = pager;

            ViewData["list"] = data;
            ViewData["math"] = math;
            ViewData["ListLoaiSP"] = context.ListLoaiSP();
            ViewData["ListHang"] = context.ListHang(3);
            return View();
        }
    }
}
