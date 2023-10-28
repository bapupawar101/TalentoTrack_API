using Microsoft.AspNetCore.Mvc;
using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.DTOs.Courses;
using TalentoTrack.Common.Services;

namespace TelentoTrack_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CourseController : ControllerBase
    {
        private readonly ILogger<CourseController> _logger;
        private readonly ICourseService _courseService;
        public CourseController(ILogger<CourseController> logger, ICourseService courseService)
        {
            _logger = logger;
            _courseService = courseService;
        }

        [HttpPost(Name = "Create")]
        public async Task<BaseResponse> Create([FromBody] InsertUpdateCourseRequest reqest)
        {
            var response = await _courseService.InsertUpdate(reqest);
           
            return response;
        }

        [HttpPost(Name = "GetAll")]
        public async Task<BaseResponse> GetAll([FromBody] GetAllRequest reqest)
        {
            var response = await _courseService.GetAll(reqest);

            return response;
        }

        [HttpGet(Name = "GetById")]
        public async Task<BaseResponse> GetById([FromQuery] GetByIdRequest reqest)
        {
            var response = await _courseService.GetById(reqest);

            return response;
        }

        [HttpDelete(Name = "Delete")]
        public async Task<BaseResponse> Delete([FromQuery] int id)
        {
            var response = await _courseService.Delete(id);

            return response;
        }

        [HttpPut(Name = "Update")]
        public async Task<BaseResponse> Update([FromBody] InsertUpdateCourseRequest request)
        {
            var response = await _courseService.InsertUpdate(request);

            return response;
        }
    }
}