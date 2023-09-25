using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Issues
{
    public class BaseIssuesDto
    {
        public int id { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
        [MaxLength(50)]
        public string Details { get; set; }
        public bool IsResolved { get; set; }
        public int StudentId { get; set; }
    }
}
