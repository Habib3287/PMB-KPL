using Microsoft.AspNetCore.Mvc;
using PMB_LIB;
using System.Linq;
using PMB_API.Models;
namespace PMB_API;

[ApiController]
[Route("api/[controller]")]
public class RegistrationController : ControllerBase
{
    private readonly AppDbContext _context;

    public RegistrationController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Register([FromBody] Registration registration)
    {
        if (registration.NewPassword != registration.ReEnterPassword)
        {
            return BadRequest("Passwords do not match.");
        }
        if (_context.Users.Any(u => u.Email == registration.Email))
        {
            return BadRequest("Email already registered.");
        }

        //transisi
        registration.State = RegistrationState.Registered;

        var user = new User
        {
            Name = registration.Name,
            Email = registration.Email,
            Phone = registration.Phone,
            Address = registration.Address,
            Birthdate = registration.Birthdate,
            Password = registration.NewPassword
        };

        _context.Users.Add(user);
        _context.SaveChanges();

        return Ok("Registration successful.");
    }
}
    
