using Infrastructure.Data;
using Infrastructure.Servises.AttendanceServises;
using Infrastructure.Servises.ClassrumServises;
using Infrastructure.Servises.ExamServises;
using Infrastructure.Servises.IssuesServises;
using Infrastructure.Servises.StudentServises;
using Infrastructure.Servises.TeacherServises;
using Infrastructure.Servises.TimeTableServises;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var con = builder.Configuration.GetConnectionString("DefaultConnection");
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(c => c.UseNpgsql(con));
builder.Services.AddScoped<IStudentServise, StudentServise>();
builder.Services.AddScoped<ITeacherServise, TeacherServise>();
builder.Services.AddScoped<IClassrumServises, ClassrumServise>();
builder.Services.AddScoped<IExamServise, ExamServise>();
builder.Services.AddScoped<ITimeTableServise, TimeTableServise>();
builder.Services.AddScoped<IIssuesServise,IssuesSevise>();
builder.Services.AddScoped<IAttendanceServise,AttendanceServise>();











builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
