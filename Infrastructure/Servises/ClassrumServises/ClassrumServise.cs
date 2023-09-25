using Domain.DTOs.ClassrumDto;
using Domain.Entity;
using Domain.Wapper;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Servises.ClassrumServises;

    public class ClassrumServise : IClassrumServises
    {
        private readonly DataContext _context;

        public ClassrumServise(DataContext context)
        {
            _context = context;
        }

    public async Task<Response<GetClassrumDto>> Add(AddClassrumDto clas)
    {
      await   _context.Classrums.AddAsync(new Classrum()
      {
          Id=clas.Id,
          Section=clas.Section,
          Grande=clas.Grande,
          TeacherId=clas.TeacherId,
          TimeTableId=clas.TimeTableId,
      });
        _context.SaveChanges();
        return new Response<GetClassrumDto>(new GetClassrumDto()
        {
            Id = clas.Id,
            Section = clas.Section,
            Grande = clas.Grande,
        });
    }

    public async Task<Response<GetClassrumDto>> Delete(int id)
    {
        _context.Classrums.Remove(await _context.Classrums.FindAsync(id));
        _context.SaveChanges();
        return new Response<GetClassrumDto>("Delete Exam");
    }

    public async Task<Response<List<GetClassrumDto>>> Get()
    {
        var std = await _context.Classrums.Select(clas => new GetClassrumDto()
        {
            Id = clas.Id,
            Section = clas.Section,
            Grande = clas.Grande,
        }).ToListAsync();
        return new Response<List<GetClassrumDto>>(std);
    }

    public async Task<Response<GetClassrumDto>> GetById(int id)
    {
        var clas = await _context.Classrums.FindAsync(id);
        return new Response<GetClassrumDto>(new GetClassrumDto()
        {
            Id = clas.Id,
            Section = clas.Section,
            Grande = clas.Grande,
        });
    }

    public async Task<Response<GetClassrumDto>> Update(AddClassrumDto clas)
    {
        var _clas = await _context.Classrums.FindAsync(clas.Id);

        _clas.Id=clas.Id;
        _clas.Section = clas.Section;
        _clas.Grande = clas.Grande;
        _clas.TeacherId= clas.TeacherId;
        _clas.TimeTableId= clas.TimeTableId;
        _context.SaveChanges();
        return new Response<GetClassrumDto>(new GetClassrumDto()
        {
            Id = clas.Id,
            Section = clas.Section,
            Grande = clas.Grande,
        });
    }
}


