

using Domain.DTOs.StudentDto;
using Domain.DTOs.TeacherDto;
using Domain.Wapper;

namespace Infrastructure.Servises.TeacherServises
{
    public interface ITeacherServise
    {
        Task<Response<List<GetTeacherDto>>> Get();
        Task<Response<GetTeacherDto>> GetById(int id);
        Task<Response<GetTeacherDto>> Update(AddTeacherDto student);
        Task<Response<GetTeacherDto>> Add(AddTeacherDto student);
        Task<Response<GetTeacherDto>> Delete(int id);
    }
}
