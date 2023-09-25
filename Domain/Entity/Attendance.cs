namespace Domain.Entity
{
    public class Attendance
    {
        public int Id { get; set; }
        public DateTime Date { get; set;}
        public bool Status { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public Student Student  { get; set; }
        public Teacher Teacher { get; set; }


    }
}
