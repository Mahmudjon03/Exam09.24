

using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.ExamDto
{
    public class BaseExamDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
    }
}
