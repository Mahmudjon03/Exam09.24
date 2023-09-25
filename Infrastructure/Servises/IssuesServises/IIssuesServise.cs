

using Domain.DTOs.ExamDto;
using Domain.DTOs.Issues;
using Domain.Wapper;

namespace Infrastructure.Servises.IssuesServises
{
    public interface IIssuesServise
    {
        Task<Response<List<BaseIssuesDto>>> Get();
        Task<Response<BaseIssuesDto>> GetById(int id);
        Task<Response<BaseIssuesDto>> Update(BaseIssuesDto issues);
        Task<Response<BaseIssuesDto>> Add(BaseIssuesDto issues);
        Task<Response<BaseIssuesDto>> Delete(int id);
    }
}
