using Domain.DTOs.TeacherDto;
using Domain.Entity;
using Domain.Wapper;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Servises.TeacherServises
{
    public class TeacherServise:ITeacherServise
    {
        private readonly DataContext _context;

        public TeacherServise(DataContext context)
        {
            _context = context;
        }

        public async Task<Response<GetTeacherDto>> Add(AddTeacherDto teacher)
        {
           await _context.Teachers.AddAsync(new Teacher()
            {
                id= teacher.id,
                Fullname= teacher.Fullname,
                Password= teacher.Password,
                Address= teacher.Address,
                Email= teacher.Email,
                Phone= teacher.Phone,
                Sex= teacher.Sex,
                DateOfJoin= teacher.DateOfJoin,
                DOB= teacher.DOB,
            });
            _context.SaveChanges();
            return new Response<GetTeacherDto>(new GetTeacherDto()
            {
                id = teacher.id,
                Fullname = teacher.Fullname,
                Password = teacher.Password,
                Address = teacher.Address,
                Email = teacher.Email,
                Phone = teacher.Phone,
                Sex = teacher.Sex,
                DateOfJoin = teacher.DateOfJoin,
                DOB = teacher.DOB,
            });

        }

        public async Task<Response<GetTeacherDto>> Delete(int id)
        {

            _context.Teachers.Remove(await _context.Teachers.FindAsync(id));
            _context.SaveChanges();
            return new Response<GetTeacherDto>("Delete Teacher");
        }

        public async Task<Response<List<GetTeacherDto>>> Get()
        {
            var teacher =await _context.Teachers.Select(teachers => new GetTeacherDto()
            {
                   id=teachers.id,
                   Fullname=teachers.Fullname,
                   Password=teachers.Password,
                   Address = teachers.Address,
                   Email = teachers.Email,
                   Phone = teachers.Phone,
                   Sex = teachers.Sex,
                   DOB= teachers.DOB,
            }).ToListAsync();
            return new Response<List<GetTeacherDto>>(teacher);
        }

       

        public async  Task<Response<GetTeacherDto>> GetById(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            return new Response<GetTeacherDto>(new GetTeacherDto()
            {
                id = teacher.id,
                Fullname = teacher.Fullname,
                Password = teacher.Password,
                Address = teacher.Address,
                Email = teacher.Email,
                Phone = teacher.Phone,
                Sex = teacher.Sex,
                DOB = teacher.DOB
            }
            );
        }

       public async Task<Response<GetTeacherDto>> Update(AddTeacherDto teacher)
        {
            var std = await _context.Teachers.FindAsync(teacher.id);
            std.id = teacher.id;
            std.Fullname = teacher.Fullname;
            std.Password = teacher.Password;
            std.Email = teacher.Email;
            std.Address = teacher.Address;
            std.Phone = teacher.Phone;
            std.Sex = teacher.Sex;
            std.DateOfJoin = teacher.DateOfJoin;
            std.DOB = teacher.DOB;
            _context.SaveChanges();
            return new Response<GetTeacherDto>(new GetTeacherDto()
            {
                id = std.id,
                Fullname = std.Fullname,
                Password = std.Password,
                Email = std.Email,
                Address = std.Address,
                Phone = std.Phone,
                Sex = std.Sex,
                DateOfJoin = std.DateOfJoin,
                DOB = std.DOB
            });
        }
    }
}
