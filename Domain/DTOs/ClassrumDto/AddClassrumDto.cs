namespace Domain.DTOs.ClassrumDto
{
    public class AddClassrumDto:BaseClassrumDto
    {
        public int TeacherId { get; set; }
        public int TimeTableId { get; set; }
    }
}
