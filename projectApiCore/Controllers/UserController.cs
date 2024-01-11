using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projectApiCore.Interfaces;
using projectApiCore.Models;
using projectApiCore.Repository;

namespace projectApiCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<ItemController> _logger;


        public UserController(IUserRepository userRepository, ILogger<ItemController> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }


    
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        public IActionResult GetCategories()
        {
           // var categories = _mapper.Map<List<CategoryDto>>(_categoryRepository.GetCategories());
           var users = _userRepository.GetUsers();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(users);
        }
    }

}
