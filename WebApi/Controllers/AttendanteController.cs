using Domain.DTOs.AttendanceDto;
using Domain.DTOs.ClassrumDto;
using Domain.Entity;
using Domain.Wapper;
using Infrastructure.Servises.AttendanceServises;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("controller")]
    public class AttendanteController
    {
        private readonly IAttendanceServise _attendance;

        public AttendanteController(IAttendanceServise attendance)
        {
            _attendance = attendance;

        }
        [HttpGet("GetAttendante")]
        public async Task<Response<List<BaseAttendanteDto>>> Get() => await _attendance.Get();
        [HttpPost("AddAttendante")]
        public async Task<Response<BaseAttendanteDto>> AddStudents(BaseAttendanteDto atten) => await _attendance.Add(atten);
        [HttpPut("UpdateAttendante")]
        public async Task<Response<BaseAttendanteDto>> Update(BaseAttendanteDto atten) => await _attendance.Update(atten);
        [HttpDelete("DeleteAttendante")]
        public async Task<Response<BaseAttendanteDto>> Delete(int id) => await _attendance.Delete(id);
        [HttpGet("GetByIdAttendante")]
        public async Task<Response<BaseAttendanteDto>> GetById(int id) => await _attendance.GetById(id);
    }
}
