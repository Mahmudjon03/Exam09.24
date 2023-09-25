using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.TimeTableDto
{
    public class BaseTimeTableDto
    {
        public int Id { get; set; }
        public string Day { get; set; }
      
        public string Time { get; set; }
      
        public string Subject { get; set; }
     
    }
}
