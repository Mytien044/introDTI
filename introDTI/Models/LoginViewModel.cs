using System.ComponentModel.DataAnnotations;

namespace introDTI.Models  // <-- QUAN TRỌNG: Namespace phải đúng tên Project của bạn
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập tài khoản")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}