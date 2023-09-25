
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Teacher
    {
        public int id { get; set; }
        [MaxLength(50)]
        public string Fullname { get; set; }
        [MaxLength(30)]
        public string Password { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        [MaxLength(30)]
        public string Phone { get; set; }
        [MaxLength(30)]
        public string Address { get; set; }
        [MaxLength(10)]
        public string Sex { get; set; }
        public DateTime DOB { get; set; }
        [MaxLength(30)]
        public string DateOfJoin { get; set; }
        public List<Attendance> Attendances  { get; set; }
        public List<Classrum> Classrum { get; set; }

    }
}
