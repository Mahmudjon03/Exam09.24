

using Domain.DTOs.AttendanceDto;
using Domain.DTOs.ClassrumDto;
using Domain.Wapper;

namespace Infrastructure.Servises.AttendanceServises
{
    public interface IAttendanceServise
    {
        Task<Response<List<BaseAttendanteDto>>> Get();
        Task<Response<BaseAttendanteDto>> GetById(int id);
        Task<Response<BaseAttendanteDto>> Update(BaseAttendanteDto clas);
        Task<Response<BaseAttendanteDto>> Add(BaseAttendanteDto clas);
        Task<Response<BaseAttendanteDto>> Delete(int id);
    }
}
