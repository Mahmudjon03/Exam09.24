using Domain.DTOs.TeacherDto;
using Domain.Wapper;
using Infrastructure.Servises.TeacherServises;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("controller")]
    public class TeacherComtroller
    {
        private readonly ITeacherServise _teacher;

        public TeacherComtroller(ITeacherServise teacher)
        {
            _teacher = teacher;
        }
        [HttpGet("GetTeacherAll")]
        public async Task<Response<List<GetTeacherDto>>> Get() => await _teacher.Get();
        [HttpPost("AddTeachers")]
        public async Task<Response<GetTeacherDto>> AddStudents(AddTeacherDto student) => await _teacher.Add(student);
        [HttpPut("UpdateTeachers")]
        public async Task<Response<GetTeacherDto>> Update(AddTeacherDto student) => await _teacher.Update(student);
        [HttpDelete("DeleteTeachers")]
        public async Task<Response<GetTeacherDto>> Delete(int id) => await _teacher.Delete(id);
        [HttpGet("GetByIdTeachers")]
        public async Task<Response<GetTeacherDto>> GetById(int id) => await _teacher.GetById(id);
    }
}
