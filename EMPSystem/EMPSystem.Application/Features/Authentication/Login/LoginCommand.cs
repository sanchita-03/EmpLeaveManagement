using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMPSystem.Application.Features.Authentication.Login
{
    public class LoginCommand : IRequest<LoginResponse>
    {
        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
