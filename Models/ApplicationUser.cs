using Microsoft.AspNetCore.Identity;

namespace ESHOPONLINE.Models
{
    public class ApplicationUser:IdentityUser
    {
    
        public ICollection<Order> Orders { get; set; } 
       
    }
}
