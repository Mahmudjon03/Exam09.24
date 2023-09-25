using Domain.DTOs.ExamDto;
using Domain.DTOs.TimeTableDto;
using Domain.Wapper;
using Infrastructure.Servises.TimeTableServises;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("controller")]
    public class timeTableController
    {
        private readonly ITimeTableServise _time;

        public timeTableController(ITimeTableServise time)
        {
            _time = time;
        }
        [HttpGet("GetTimeTables")]
        public async Task<Response<List<GetTimeTable>>> Get() => await _time.Get();
        [HttpPost("AddTimeTables")]
        public async Task<Response<GetTimeTable>> AddStudents(AddTimeTableDto time) => await _time.Add(time);
        [HttpPut("UpdateTimeTables")]
        public async Task<Response<GetTimeTable>> Update(AddTimeTableDto time) => await _time.Update(time);
        [HttpDelete("DeleteTimeTable")]
        public async Task<Response<GetTimeTable>> Delete(int id) => await _time.Delete(id);
        [HttpGet("GetByIdTimeTables")]
        public async Task<Response<GetTimeTable>> GetById(int id) => await _time.GetById(id);
    }
}
