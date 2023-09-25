

using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Student
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
        [MaxLength (50)]
        public string DateOfJoin { get; set; }
        public List<Result> Result { get; set; }
        public List<Attendance> Attendance { get; set; }
        public List<ClassrumStudent> ClassrumStudent { get; set; }
        public List<Issues>  Issues { get; set; }
    }
}
