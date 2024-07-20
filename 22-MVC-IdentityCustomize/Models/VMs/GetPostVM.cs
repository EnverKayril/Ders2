namespace _22_MVC_IdentityCustomize.Models.VMs
{
    public class GetPostVM
    {
        public List<Category> Categories { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
    }
}
