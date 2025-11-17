using Microsoft.AspNetCore.Identity;

namespace Listura_v1._0.Models
{
    public class User:IdentityUser
    {
        public string DisplayName { get; set; }
        public ICollection<Section> sections { get; set; }
    }
}
