

using Domain.DTOs.ExamDto;
using Domain.DTOs.Issues;
using Domain.Entity;
using Domain.Wapper;
using Infrastructure.Data;
using Infrastructure.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Servises.IssuesServises
{
    public class IssuesSevise : IIssuesServise
    {
        private readonly DataContext _context;

        public IssuesSevise(DataContext context)
        {
            _context = context;
        }
        public async Task<Response<BaseIssuesDto>> Add(BaseIssuesDto issues)
        {
            {
                await _context.Isses.AddAsync(new Issues()
                {
                    id = issues.id,
                    Type = issues.Type,
                    Details = issues.Details,
                    IsResolved = issues.IsResolved,
                    StudentId = issues.StudentId,
                });
                _context.SaveChanges();
                return new Response<BaseIssuesDto>(issues);
            }
        }
            public async Task<Response<BaseIssuesDto>> Delete(int id)
            { 
                
                _context.Isses.Remove(await _context.Isses.FindAsync(id));
                _context.SaveChanges();
                return new Response<BaseIssuesDto>("Delete Issues");
            }

        public async Task<Response<List<BaseIssuesDto>>> Get()
        {
            var std = await _context.Isses.Select(issues => new BaseIssuesDto()
            {
                id = issues.id,
                Type = issues.Type,
                Details = issues.Details,
                IsResolved = issues.IsResolved,
                StudentId = issues.StudentId,
            }).ToListAsync();
            return new Response<List<BaseIssuesDto>>(std);
        }

        public async Task<Response<BaseIssuesDto>> GetById(int id)
        {
            var issues= await _context.Isses.FindAsync(id);
            return new Response<BaseIssuesDto>(new BaseIssuesDto()
            {
                id = issues.id,
                Type = issues.Type,
                Details = issues.Details,
                IsResolved = issues.IsResolved,
                StudentId = issues.StudentId,
            });
        }

        public async Task<Response<BaseIssuesDto>> Update(BaseIssuesDto issues)
        {
            var _issues = await _context.Isses.FindAsync(issues.id);
            _issues.id = issues.id;
            _issues.Type = issues.Type;
            _issues.Details = issues.Details;
            _issues.IsResolved = issues.IsResolved;
            _issues.StudentId = issues.StudentId;
           _context.SaveChanges();
             return new Response<BaseIssuesDto>(issues);
            
        }
    }
}
