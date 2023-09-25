using Domain.DTOs.StudentDto;
using Domain.Wapper;

namespace Infrastructure.Servises.StudentServises
{
    public interface IStudentServise
    {
        Task<Response<List<GetStudentDto>>> Get();
        Task<Response<GetStudentDto>> GetById(int id);
        Task<Response<GetStudentDto>> Update(AddStudentDto student);
        Task<Response<GetStudentDto>> Add(AddStudentDto student);
        Task<Response<GetStudentDto>> Delete(int id);
    }
}
