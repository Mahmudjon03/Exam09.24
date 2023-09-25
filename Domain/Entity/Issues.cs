
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Issues
    {
        public int id { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
        [MaxLength(50)]
        public string Details { get; set; }
        public bool IsResolved { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
