using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.DTOs.Courses;

namespace TalentoTrack.Common.Services
{
    public interface ICourseService
    {
        Task<BaseResponse> InsertUpdate(InsertUpdateCourseRequest request);
        Task<GetAllResponse> GetAll(GetAllRequest request);
        Task<GetByIdResponse> GetById(GetByIdRequest request);
        Task<BaseResponse> Delete(int id);
    }
}
