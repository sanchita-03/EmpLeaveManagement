using EMPSystem.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using BCrypt.Net;

namespace EMPSystem.Infrastructure.Repository
{
    public class PasswordHasherRepository : IPasswordHasher
    {
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
        
    }
}
