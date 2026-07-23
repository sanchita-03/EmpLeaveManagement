using EMPSystem.Application.Interfaces;
using EMPSystem.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMPSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public AuthController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<User> GetUserAsync(string email) 
        {
            var user = await _userRepository.GetByEmailAsync(email);
            return user;
        }

    }
}
