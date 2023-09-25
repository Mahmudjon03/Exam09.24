
using Domain.DTOs.TeacherDto;
using Domain.DTOs.TimeTableDto;
using Domain.Entity;
using Domain.Wapper;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Servises.TimeTableServises
{
    public class TimeTableServise:ITimeTableServise
    {
        private readonly DataContext _context;

        public TimeTableServise(DataContext context)
        {
            _context = context;
        }

        public async Task<Response<GetTimeTable>> Add(AddTimeTableDto time)
        {
            await _context.TimeTables.AddAsync(new TimeTable()
            {
               Id = time.Id,
               Day = time.Day,
               Time=time.Time,
               Subject=time.Subject,

            });
            _context.SaveChanges();
            return new Response<GetTimeTable>(new GetTimeTable()
            {
                Id = time.Id,
                Day = time.Day,
                Time = time.Time,
                Subject = time.Subject,
            });
        }

        public async Task<Response<GetTimeTable>> Delete(int id)
        {
            _context.TimeTables.Remove(await _context.TimeTables.FindAsync(id));
            _context.SaveChanges();
            return new Response<GetTimeTable>("Delete TimeTable");
        }

        public async Task<Response<List<GetTimeTable>>> Get()
        {
            var _time = await _context.TimeTables.Select(time => new GetTimeTable()
            {
                Id = time.Id,
                Day = time.Day,
                Time = time.Time,
                Subject = time.Subject,

            }).ToListAsync();
            return new Response<List<GetTimeTable>>(_time);
        }

        public async Task<Response<GetTimeTable>> GetById(int id)
        {
            var time = await _context.TimeTables.FindAsync(id);
            return new Response<GetTimeTable>(new GetTimeTable()
            {
                Id = time.Id,
                Day = time.Day,
                Time = time.Time,
                Subject = time.Subject,
            }
            );
        }

        public async Task<Response<GetTimeTable>> Update(AddTimeTableDto time)
        {
            var std = await _context.TimeTables.FindAsync(time.Id);
          
            std.Id=time.Id;
            std.Day=time.Day;
            std.Time=time.Time;
            std.Subject=time.Subject;
            _context.SaveChanges();
            return new Response<GetTimeTable>(new GetTimeTable()
            {
                Id = time.Id,
                Day = time.Day,
                Time = time.Time,
                Subject = time.Subject,
            });
        }
    }

      
}
