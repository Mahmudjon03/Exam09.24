

using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Classrum
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string  Section { get; set; }
        public int Grande { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int TimeTableId { get; set; }
        public TimeTable TimeTable { get; set; }
        public List<ClassrumStudent> ClassrumStudent { get; set; }
        public List<Subject> Subjects { get; set; }



    }
}
