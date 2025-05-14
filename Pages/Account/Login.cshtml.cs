using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Autenticacion.Model;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs;

namespace Autenticacion.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]

        public User User { get; set; }
        public void OnGet()
        {
        }

        public void OnPost() {
            Console.WriteLine("User: " + User.Email + "Password : " + User.Password);
        }
    }
}
