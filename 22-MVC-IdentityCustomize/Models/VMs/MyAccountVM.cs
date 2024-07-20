namespace _22_MVC_IdentityCustomize.Models.VMs
{
    public class MyAccountVM
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<BlogPost> BlogPosts { get; set; }
    }
}
