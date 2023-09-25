using Domain.DTOs.StudentDto;
using Domain.Wapper;
using Infrastructure.Servises.StudentServises;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("controller")]
    public class StudentController:ControllerBase
    {
        private readonly IStudentServise _student;

        public StudentController(IStudentServise student)
        {
            _student = student;
        }
        [HttpGet("GetStudentAll")]
        public async Task<Response<List<GetStudentDto>>> Get() => await _student.Get();
        [HttpPost("AddStudents")]
        public async Task<Response<GetStudentDto>>  AddStudents(AddStudentDto student)=> await _student.Add(student);
        [HttpPut("UpdateStudents")]
        public async Task<Response<GetStudentDto>> Update(AddStudentDto student)=> await _student.Update(student);
        [HttpDelete("DeleteStudent")]
        public async Task<Response<GetStudentDto>> Delete(int id)=>  await _student.Delete(id);
        [HttpGet("GetByIdStudents")]
        public async Task<Response<GetStudentDto>> GetById(int id)=> await _student.GetById(id);
    }
}