
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Exam
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public int Type { get; set; }
        public List<Result> Results { get; set; }
    }
}
