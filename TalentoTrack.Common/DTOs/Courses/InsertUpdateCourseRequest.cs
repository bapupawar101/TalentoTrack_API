using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentoTrack.Common.DTOs.Courses
{
    public class InsertUpdateCourseRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double TotalFees { get; set; }
        public int DurationInDays { get; set; }
    }
}
