

using Domain.DTOs.ExamDto;
using Domain.DTOs.StudentDto;
using Domain.Wapper;

namespace Infrastructure.Servises.ExamServises
{
    public interface IExamServise
    {
        Task<Response<List<GetExamDto>>> Get();
        Task<Response<GetExamDto>> GetById(int id);
        Task<Response<GetExamDto>> Update(AddExamDto exam);
        Task<Response<GetExamDto>> Add(AddExamDto exam);
        Task<Response<GetExamDto>> Delete(int id);
    }
}
