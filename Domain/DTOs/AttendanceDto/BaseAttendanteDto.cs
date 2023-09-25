

namespace Domain.DTOs.AttendanceDto
{
    public class BaseAttendanteDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }

    }
}
