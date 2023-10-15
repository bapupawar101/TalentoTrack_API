using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentoTrack.Common.Entities
{
    public class Course : BaseEntity
    {
        public string? Name { get; set; }
        public double TotalFees { get; set; }
        public int DurationInDays { get; set; }
    }
}
