using Microsoft.AspNetCore.Identity;

namespace Application.Microservices.Services.AuthAPI.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
    }
}
