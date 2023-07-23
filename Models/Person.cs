namespace challenge_back_end.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
