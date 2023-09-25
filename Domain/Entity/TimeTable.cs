
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Domain.Entity
{
    public class TimeTable
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Day { get; set; }
        [MaxLength(50)]
        public string Time { get; set; }
        [MaxLength(50)]
        public string Subject { get; set; }
        public List<Classrum> Classrum { get; set; }
    }
}
