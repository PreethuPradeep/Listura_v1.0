using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Query;

namespace Listura_v1._0.Models
{
    public class AppUser : IdentityUser
    {
        public string UserId { get; set; }
        public string DisplayName { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
