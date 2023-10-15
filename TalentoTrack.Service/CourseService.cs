using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.DTOs.Courses;
using TalentoTrack.Common.Repositories;
using TalentoTrack.Common.Services;

namespace TalentoTrack.Service
{
    public class CourseService : ICourseService
    {
        public readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<BaseResponse> InsertUpdate(InsertUpdateCourseRequest request)
        {
            BaseResponse response = new BaseResponse();
            try
            {
                var course = new Common.Entities.Course()
                {
                    Id = request.Id,
                    Name = request.Name,
                    DurationInDays = request.DurationInDays,
                    TotalFees = request.TotalFees,
                    CreatedById = 0,
                    UpdatedById = null,
                    CreateDateTime = DateTime.Now,
                    UpdateDateTime = null,
                };

                if (course.Id != 0)
                {
                    course.UpdatedById = 0;
                    course.UpdateDateTime = DateTime.Now;
                }
                
                response.Success = await _courseRepository.InsertUpdate(course);
            }
            catch (Exception ex)
            {
                //TODO: Log error
                response.ErrorMessage = ex.Message;
                response.Success = false;
                //throw;
            }

            return response;
        }

        public async Task<GetAllResponse> GetAll(GetAllRequest request)
        {
            GetAllResponse response = new GetAllResponse();
            try
            {
                response.Data = await _courseRepository.GetAll(request);

                return response;
            }
            catch (Exception ex)
            {
                //TODO: Log error
                throw;
            }
        }

        public async Task<GetByIdResponse> GetById(GetByIdRequest request)
        {
            GetByIdResponse response = new GetByIdResponse();
            try
            {
                response.Data = await _courseRepository.GetById(request);

                return response;
            }
            catch (Exception ex)
            {
                //TODO: Log error
                throw;
            }
        }

        public async Task<BaseResponse> Delete(int id)
        {
            BaseResponse response = new BaseResponse();
            try
            {
                response.Success = await _courseRepository.Delete(id);

                return response;
            }
            catch (Exception ex)
            {
                //TODO: Log error
                throw;
            }
        }
    }
}
