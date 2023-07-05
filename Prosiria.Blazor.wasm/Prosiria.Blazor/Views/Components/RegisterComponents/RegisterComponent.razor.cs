// ---------------------------------------------------------------
// Copyright (c) Cydista. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace Prosiria.Blazor.Views.Components.RegisterComponents
{
    public partial class RegisterComponent : ComponentBase
    {
        private SignUpModel model = new SignUpModel();

        private void HandleValidSubmit()
        {
        }

        private class SignUpModel
        {
            [Required]
            [StringLength(50)]
            public string Username { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [StringLength(50, MinimumLength = 8)]
            public string Password { get; set; }
        }
    }
}