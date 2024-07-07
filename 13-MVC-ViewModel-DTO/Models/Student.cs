namespace _13_MVC_ViewModel_DTO.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime Date { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
