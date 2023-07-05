using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Prosiria.Blazor.Views.Components.LoginComponents
{
    public partial class LoginComponent : ComponentBase
    {
        [Inject]
        public AuthenticationStateProvider AuthStateProvider { get; set; }
        private LoginModel loginModel = new LoginModel();

        private async Task HandleValidSubmit()
        {

        }

        private void ToggleCheckBox()
        {
            this.loginModel.RememberMe = !this.loginModel.RememberMe;
        }

        private class LoginModel
        {
            [Required(ErrorMessage = "Username is required")]
            public string Username { get; set; }

            [Required(ErrorMessage = "Password is required")]
            public string Password { get; set; }
            [Required]
            public bool RememberMe { get; set; } = false;
        }
    }
}