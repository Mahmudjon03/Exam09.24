
using Domain.DTOs.TeacherDto;
using Domain.DTOs.TimeTableDto;
using Domain.Wapper;

namespace Infrastructure.Servises.TimeTableServises
{
    public interface ITimeTableServise
    {
        Task<Response<List<GetTimeTable>>> Get();
        Task<Response<GetTimeTable>> GetById(int id);
        Task<Response<GetTimeTable>> Update(AddTimeTableDto student);
        Task<Response<GetTimeTable>> Add(AddTimeTableDto student);
        Task<Response<GetTimeTable>> Delete(int id);
    }
}
