
namespace Domain.Entity
{
    public class Result
    {
        public int Id { get; set; }
        public int Marks { get; set; }
        public int ExamId { get; set; }
        public Exam Exam  { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int  SubjectId { get; set; }
        public Subject Subject { get; set; }

    }
}
