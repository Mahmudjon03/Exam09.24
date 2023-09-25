 using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.TeacherDto
{
    public class BaseTeacherDto
    {

        public int id { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        public DateTime DOB { get; set; }
        public string DateOfJoin { get; set; }
    }
}
