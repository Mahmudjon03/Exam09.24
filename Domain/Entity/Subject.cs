
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Subject
    {
        public int  Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public int Grande { get; set; }
        public string Description { get; set; }
        public int ClassrumId { get; set; }
        public Classrum Classrum { get; set; }
        public List<Result> Result { get; set; }


    }
}
