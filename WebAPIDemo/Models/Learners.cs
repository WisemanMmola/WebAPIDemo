namespace WebAPIDemo.Models
{

    //Learners information
    public class Learners
    {
        public Guid Id { get; set; }
        public required string LearnerName { get; set; }
        public required string LearnerSurname { get; set; }
        public required string LearnerEmail { get; set; }
        public string? LearnerPhone { get; set; }
        public required string LearnerIdNumber { get; set; }
    }
}
