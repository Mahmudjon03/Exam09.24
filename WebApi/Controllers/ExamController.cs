using Domain.DTOs.ClassrumDto;
using Domain.DTOs.ExamDto;
using Domain.Entity;
using Domain.Wapper;
using Infrastructure.Servises.ExamServises;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("controller")]
    public class ExamController
    {
        private readonly IExamServise _exam;

        public ExamController(IExamServise exam)
        {
            _exam = exam;
        }
        [HttpGet("GetExams")]
        public async Task<Response<List<GetExamDto>>> Get() => await _exam.Get();
        [HttpPost("AddExams")]
        public async Task<Response<GetExamDto>> AddStudents(AddExamDto exam) => await _exam.Add(exam);
        [HttpPut("UpdateExams")]
        public async Task<Response<GetExamDto>> Update(AddExamDto exam) => await _exam.Update(exam);
        [HttpDelete("DeleteExam")]
        public async Task<Response<GetExamDto>> Delete(int id) => await _exam.Delete(id);
        [HttpGet("GetByIdExams")]
        public async Task<Response<GetExamDto>> GetById(int id) => await _exam.GetById(id);
    }
}
