using System;
using System.Collections.Generic;
using System.Text;

namespace EMPSystem.Application.Features.Authentication.Login
{
    public class LoginResponse
    {
        public bool Success { get; set; }

        public string Token { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;
    }
}
