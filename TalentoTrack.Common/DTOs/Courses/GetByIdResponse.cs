using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.Entities;

namespace TalentoTrack.Common.DTOs.Courses
{
    public class GetByIdResponse : BaseResponse
    {
        public Course? Data { get; set; }
    }
}