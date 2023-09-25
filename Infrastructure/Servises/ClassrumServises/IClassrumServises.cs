using Domain.DTOs.ClassrumDto;

using Domain.Wapper;

namespace Infrastructure.Servises.ClassrumServises;

    public interface IClassrumServises
    {
        Task<Response<List<GetClassrumDto>>> Get();
        Task<Response<GetClassrumDto>> GetById(int id);
        Task<Response<GetClassrumDto>> Update(AddClassrumDto clas);
        Task<Response<GetClassrumDto>> Add(AddClassrumDto clas);
        Task<Response<GetClassrumDto>> Delete(int id);
    }
