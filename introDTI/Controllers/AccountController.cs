using Microsoft.AspNetCore.Mvc;

namespace DTI.Web.Controllers // Đổi namespace này theo tên Project của bạn (VD: IntroDTI.Controllers)
{
    public class AccountController : Controller
    {
        // Action để hiển thị trang Login
        // Đường dẫn sẽ là: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Action để xử lý khi người dùng bấm nút "Đăng nhập" (Submit form)
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Code xử lý đăng nhập sẽ viết ở đây sau này
            // Tạm thời cứ cho về trang chủ
            return RedirectToAction("Index", "Home");
        }
    }
}