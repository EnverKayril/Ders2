namespace _22_MVC_IdentityCustomize.Models.VMs
{
    public class GetMainPostVM
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public string UserName { get; set; }
    }
}
