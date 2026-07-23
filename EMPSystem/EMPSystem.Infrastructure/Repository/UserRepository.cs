using System;
using System.Collections.Generic;
using System.Text;
using EMPSystem.Application.Interfaces;
using EMPSystem.Domain.Entities;
using EMPSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EMPSystem.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task AddAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            var user = await _applicationDbContext.Users.FirstOrDefaultAsync(x=>x.Email==email);
            return user;
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
