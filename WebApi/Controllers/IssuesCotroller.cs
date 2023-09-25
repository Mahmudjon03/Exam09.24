using Domain.DTOs.ClassrumDto;
using Domain.DTOs.Issues;
using Domain.Entity;
using Domain.Wapper;
using Infrastructure.Servises.IssuesServises;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("controller")]
    public class IssuesCotroller:ControllerBase
    {
        private readonly IIssuesServise _issues;

        public IssuesCotroller(IIssuesServise issues)
        {
            _issues = issues;
        }
        [HttpGet("GetIssues")]
        public async Task<Response<List<BaseIssuesDto>>> Get() => await _issues.Get();
        [HttpPost("AddIssues")]
        public async Task<Response<BaseIssuesDto>> AddStudents(BaseIssuesDto issues) => await _issues.Add(issues);
        [HttpPut("Updateissues")]
        public async Task<Response<BaseIssuesDto>> Update(BaseIssuesDto issues) => await _issues.Update(issues);
        [HttpDelete("DeleteIssues")]
        public async Task<Response<BaseIssuesDto>> Delete(int id) => await _issues.Delete(id);
        [HttpGet("GetByIdIssues")]
        public async Task<Response<BaseIssuesDto>> GetById(int id) => await _issues.GetById(id);
    }
}
