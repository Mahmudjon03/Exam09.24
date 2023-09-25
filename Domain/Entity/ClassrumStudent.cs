
namespace Domain.Entity
{
    public class ClassrumStudent
    {
        public int StudentId { get; set; }
        public int ClassrumId { get; set; }
        public Student Student { get; set; }
        public Classrum Classrum { get; set; }
  }
}
