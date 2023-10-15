using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.Entities;

namespace TalentoTrack.Common.DTOs.Courses
{
    public class GetAllResponse : BaseResponse
    {
        public List<Course>? Data { get; set; }
    }
}