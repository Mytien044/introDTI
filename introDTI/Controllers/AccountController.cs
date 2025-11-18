using Microsoft.AspNetCore.Mvc;
using introDTI.Models; // Nhớ using namespace chứa ViewModel

namespace introDTI.Controllers
{
    public class AccountController : Controller
    {
        // 1. Hiển thị trang Login
        [HttpGet]
        public IActionResult Login()
        {
            // Trả về View kèm theo một Model rỗng để tránh lỗi null
            return View(new LoginViewModel());
        }

        // 2. Xử lý khi bấm nút Đăng nhập
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            // Kiểm tra xem dữ liệu gửi lên có hợp lệ không (Required)
            if (!ModelState.IsValid)
            {
                return View(model); // Trả lại View để hiện lỗi đỏ
            }

            // --- GIẢ LẬP KIỂM TRA ĐĂNG NHẬP ---
            // Sau này chỗ này sẽ gọi xuống Database SQL Server
            if (model.Username == "admin" && model.Password == "123456")
            {
                // Đăng nhập thành công -> Chuyển về trang chủ Dashboard
                // RedirectToAction("TênAction", "TênController");
                return RedirectToAction("Index", "Home");
            }

            // Nếu sai mật khẩu
            ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng.");
            return View(model);
        }
    }
}