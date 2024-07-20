using Microsoft.AspNetCore.Identity;

namespace _22_MVC_IdentityCustomize.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<BlogPost> BlogPosts { get; set; }
    }
}
