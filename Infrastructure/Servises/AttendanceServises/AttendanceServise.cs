using Domain.DTOs.AttendanceDto;
using Domain.DTOs.ClassrumDto;
using Domain.Entity;
using Domain.Wapper;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Servises.AttendanceServises
{
    public class AttendanceServise : IAttendanceServise
    {
        private readonly DataContext _context;

        public AttendanceServise(DataContext context)
        {
            _context = context;
        }
        public async Task<Response<BaseAttendanteDto>> Add(BaseAttendanteDto atten)
        {
            await _context.Attendances.AddAsync(new Attendance()
            {
               Id = atten.Id,
               Date = atten.Date,
               Status = atten.Status,
               StudentId= atten.StudentId,
               TeacherId= atten.TeacherId,

            });
            _context.SaveChanges();
            return new Response<BaseAttendanteDto>(atten);
        }

        public async Task<Response<BaseAttendanteDto>> Delete(int id)
        {
            _context.Attendances.Remove(await _context.Attendances.FindAsync(id));
            _context.SaveChanges();
            return new Response<BaseAttendanteDto>("Delete Exam");
        }

        public async Task<Response<List<BaseAttendanteDto>>> Get()
        {
            var std = await _context.Attendances.Select(atten => new BaseAttendanteDto()
            {
                Id = atten.Id,
                Date = atten.Date,
                Status = atten.Status,
                StudentId = atten.StudentId,
                TeacherId = atten.TeacherId,
            }).ToListAsync();
            return new Response<List<BaseAttendanteDto>>(std);
        }

        public async Task<Response<BaseAttendanteDto>> GetById(int id)
        {
            var atten = await _context.Attendances.FindAsync(id);
            return new Response<BaseAttendanteDto>(new BaseAttendanteDto()
            {
                Id = atten.Id,
                Date = atten.Date,
                Status = atten.Status,
                StudentId = atten.StudentId,
                TeacherId = atten.TeacherId,
            });
        }

        public async Task<Response<BaseAttendanteDto>> Update(BaseAttendanteDto atten)
        {
            var _atten = await _context.Attendances.FindAsync(atten.Id);

            _atten.Id=atten.Id;
            _atten.Date=atten.Date;
            _atten.Status=atten.Status;
            _atten.StudentId=atten.StudentId;
            _atten.TeacherId=atten.TeacherId;
            _context.SaveChanges();
            return new Response<BaseAttendanteDto>(new BaseAttendanteDto());
           
        }
    }
}
