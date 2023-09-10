using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class TinhLaiXuatController : Controller
    {
        public IActionResult TinhLaiXuat()
        {
            return View();
        }
        [HttpPost]
        
    public IActionResult TinhLaiXuat(int soTien, int kyHan, double laiSuat)
        {
            ViewData["soTien"] = soTien;
            ViewData["laiSuat"] = laiSuat;
            ViewData["kyHan"] = kyHan;
            ViewData["soTienLai"]= Math.Round(soTien * Math.Pow(1 + laiSuat / 100, kyHan)-soTien, 4);
            ViewData["tongSoTien"]= Math.Round(soTien*Math.Pow(1+laiSuat/100,kyHan),4);
           
            return View();
        }
        
    }
}
