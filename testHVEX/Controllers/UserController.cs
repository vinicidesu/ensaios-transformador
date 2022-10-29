using Microsoft.AspNetCore.Mvc;
using testHVEX.Models;
using testHVEX.Services;

namespace testHVEX.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly TestHvexDbService testHvexDbService;

        public UserController(TestHvexDbService testHvexDbService)
        {
            this.testHvexDbService = testHvexDbService;
        }

        [HttpGet]
        public async Task<List<User>> Get() 
        {
            return await testHvexDbService.GetAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user) 
        {
            await testHvexDbService.CreateAsync(user);
            return CreatedAtAction(nameof(Get), new {id = user.Id}, user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AddToUser(string id, [FromBody] string name)
        {
            await testHvexDbService.AddToUserAsync(id, name);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id) 
        {
            await testHvexDbService.DeleteAsync(id);
            return NoContent();
        }
    }
}
