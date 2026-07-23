using EMPSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMPSystem.Application.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(User user);
    }
}
