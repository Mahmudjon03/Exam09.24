using Domain.DTOs.ExamDto;
using Domain.Entity;
using Domain.Wapper;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Entity;

namespace Infrastructure.Servises.ExamServises
{
    public class ExamServise : IExamServise
    {
        private readonly DataContext _context;

        public ExamServise(DataContext context)
        {
            _context = context;
        }
        public async Task<Response<GetExamDto>> Add(AddExamDto exam)
        {
          await  _context.Exams.AddAsync(new Exam()
          {
              Id = exam.Id,
              Date = exam.Date,
              Name = exam.Name,
              Type = exam.Type
          });
            _context.SaveChanges();
            return new Response<GetExamDto>(new GetExamDto()
            {
                Id = exam.Id,
                Date = exam.Date,
                Name = exam.Name,
                Type = exam.Type
            });
        }

        public async Task<Response<GetExamDto>> Delete(int id)
        {
            _context.Exams.Remove( await _context.Exams.FindAsync(id));
            _context.SaveChanges();
            return new Response<GetExamDto>("Delete Exam");
        }

        public async Task<Response<List<GetExamDto>>> Get()
        {
            var std = await _context.Exams.Select(exam => new GetExamDto()
            {  
                Id = exam.Id,
                Date = exam.Date,
                Name = exam.Name,
                Type = exam.Type
            }).ToListAsync();
            return new Response<List<GetExamDto>>(std);
        }

        public async Task<Response<GetExamDto>> GetById(int id)
        {
            var exam = await _context.Exams.FindAsync(id);
            return new Response<GetExamDto>(new GetExamDto()
            {
                Id = exam.Id,
                Date = exam.Date,
                Name = exam.Name,
                Type = exam.Type
              });
        }

        public async Task<Response<GetExamDto>> Update(AddExamDto exam)
        {
            var _exam = await _context.Exams.FindAsync(exam.Id);
           
              _exam.Id=exam.Id;
            _exam.Name=exam.Name;
            _exam.Type=exam.Type;
            _exam.Date=exam.Date;
            _context.SaveChanges();
            return new Response<GetExamDto>(new GetExamDto()
            {
                Id = exam.Id,
                Date = exam.Date,
                Name = exam.Name,
                Type = exam.Type
            });
        }
    }
}
