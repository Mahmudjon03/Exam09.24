using Domain.DTOs.StudentDto;
using Domain.Entity;
using Domain.Wapper;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Servises.StudentServises
{
    public class StudentServise:IStudentServise
    {
        private readonly DataContext _context;

        public StudentServise(DataContext context)
        {
            _context = context;
        }

        public async Task<Response<GetStudentDto>> Add(AddStudentDto student)
        {
            await _context.Students.AddAsync(new Student()
            {
                id = student.id,
                Fullname=student.Fullname,
                Password=student.Password,
                Email=student.Email,
                Address=student.Address,
                Phone=student.Phone,    
                Sex=student.Sex,
                DateOfJoin=student.DateOfJoin,
                DOB=student.DOB    
            }) ;
            _context.SaveChanges();
            return new Response<GetStudentDto>(new GetStudentDto()
            {
                id = student.id,
                Fullname = student.Fullname,
                Password = student.Password,
                Email = student.Email,
                Address = student.Address,
                Phone = student.Phone,
                Sex = student.Sex,
                DateOfJoin = student.DateOfJoin,
                DOB = student.DOB
            });
        }

        public async Task<Response<GetStudentDto>> Delete(int id)
        {
            _context.Students.Remove(await _context.Students.FindAsync(id));
            _context.SaveChanges();
            return new Response<GetStudentDto>("Delete Student");
        }

        public async Task<Response<List<GetStudentDto>>>  Get()
        {
            var std = await _context.Students.Select(student => new GetStudentDto()
            {
                id = student.id,
                Fullname = student.Fullname,
                Password = student.Password,
                Email = student.Email,
                Address = student.Address,
                Phone = student.Phone,
                Sex = student.Sex,
                DateOfJoin = student.DateOfJoin,
                DOB = student.DOB
            }).ToListAsync();

           return  new Response<List<GetStudentDto>>(std);
        }

        public async Task<Response<GetStudentDto>> GetById(int id)
        {
            var std = await _context.Students.FindAsync(id);
            return new Response<GetStudentDto>(new GetStudentDto()
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

        public async Task<Response<GetStudentDto>> Update(AddStudentDto student)
        {
            var std = await _context.Students.FindAsync(student.id);
                  std.id=student.id;
                  std.Fullname=student.Fullname;
                  std.Password=student.Password;
                  std.Email=student.Email;
                  std.Address=student.Address;
                  std.Phone= student.Phone;
                  std.Sex=student.Sex;
                  std.DateOfJoin=student.DateOfJoin;
                  std.DOB=student.DOB;
                _context.SaveChanges();
            return new Response<GetStudentDto>(new GetStudentDto()
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
