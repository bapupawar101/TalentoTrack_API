using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.DTOs.Courses;
using TalentoTrack.Common.Entities;

namespace TalentoTrack.Common.Repositories
{
    public interface ICourseRepository
    {
        Task<bool> InsertUpdate(Course course);
        Task<List<Course>> GetAll(GetAllRequest request);
        Task<Course> GetById(GetByIdRequest request);
        Task<bool> Delete(int id);
    }
}
