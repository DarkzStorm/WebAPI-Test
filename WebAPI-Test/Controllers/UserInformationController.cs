using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_Test.Data;
using WebAPI_Test.Models;

namespace WebAPI_Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserInformationController : ControllerBase
    {
        private ApplicationDbContext _context;
        private IConfiguration _configuration;
        private readonly ILogger<UserInformationController> _logger;

        public UserInformationController(ApplicationDbContext context, IConfiguration configuration, ILogger<UserInformationController> logger)
        {
            _context = context;
            _configuration = configuration;
            _logger = logger;
        }

        [HttpGet]
        [Route("Get/")]
        public async Task<ActionResult> Get(int Id)
        {
            var userInformation = await _context.UserInformations.FindAsync(Id);
            if (userInformation == null)
            {
                return NotFound();
            }

            return Ok(userInformation);
        }

        [HttpPost]
        [Route("Create/")]
        public async Task<ActionResult> Create(UserInformation userInformation)
        {
            _context.UserInformations.Add(userInformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = userInformation.Id }, userInformation);
        }

        [HttpPut]
        [Route("Update/")]
        public async Task<IActionResult> Update(int Id, UserInformation userInformation)
        {
            if (Id != userInformation.Id)
            {
                return BadRequest();
            }

            _context.Entry(userInformation).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("Delete/")]
        public async Task<IActionResult> Delete(int Id)
        {
            var userInformation = await _context.UserInformations.FindAsync(Id);
            if (userInformation == null)
            {
                return NotFound();
            }

            _context.UserInformations.Remove(userInformation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet]
        [Route("Search/")]
        public ActionResult Search(string? Email, string? PhoneNumber, string? SortField)
        {
            if (Email == null && PhoneNumber == null)
            {
                return BadRequest();
            }

            if (_context.UserInformations == null)
            {
                return Problem("Entity set UserInformation is null.");
            }

            var userInformation = from a in _context.UserInformations
                                  select a;

            if (!string.IsNullOrEmpty(Email))
            {
                userInformation = userInformation.Where(b => b.Email.Contains(Email));
            }

            if (!string.IsNullOrEmpty(PhoneNumber))
            {
                userInformation = userInformation.Where(c => c.PhoneNumber == PhoneNumber);
            }

            switch(SortField)
            {
                case "FullName":
                    userInformation = userInformation.OrderBy(d => d.FullName);
                    break;
                case "Email":
                    userInformation = userInformation.OrderBy(e => e.Email);
                    break;
                case "PhoneNumber":
                    userInformation = userInformation.OrderBy(f => f.PhoneNumber);
                    break;
                case "Age":
                    userInformation = userInformation.OrderBy(g => g.Age);
                    break;
                default:
                    userInformation = userInformation.OrderBy(h => h.Id);
                    break;
            }

            return Ok(userInformation);
        }
    }
}
