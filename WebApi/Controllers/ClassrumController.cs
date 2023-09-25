using Domain.DTOs.ClassrumDto;
using Domain.DTOs.StudentDto;
using Domain.Entity;
using Domain.Wapper;
using Infrastructure.Servises.ClassrumServises;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("controller")]
    public class ClassrumController
    {
        private readonly IClassrumServises _classrum;

        public ClassrumController(IClassrumServises classrum)
        {
            _classrum = classrum;
        }
        [HttpGet("GetClassAll")]
        public async Task<Response<List<GetClassrumDto>>> Get() => await _classrum.Get();
        [HttpPost("AddClassrums")]
        public async Task<Response<GetClassrumDto>> AddStudents(AddClassrumDto clas) => await _classrum.Add(clas);
        [HttpPut("UpdateClassrums")]
        public async Task<Response<GetClassrumDto>> Update(AddClassrumDto clas) => await _classrum.Update(clas);
        [HttpDelete("DeleteClassrum")]
        public async Task<Response<GetClassrumDto>> Delete(int id) => await _classrum.Delete(id);
        [HttpGet("GetByIdClassruns")]
        public async Task<Response<GetClassrumDto>> GetById(int id) => await _classrum.GetById(id);
    }
}
