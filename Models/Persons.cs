namespace api_persons.Models
{
    public class Person{
        public int Id { get; set; }
        public required int DocumentId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required int Age { get; set; }
        public required int PhoneNumber { get; set; }
    }
}