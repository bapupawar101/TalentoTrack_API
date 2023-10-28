using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.Entities;

namespace TalentoTrack.Common.DTOs.Account
{
    public class LoginResponse : BaseResponse
    {
        public User? User { get; set; }
    }

    //public class Error
    //{
    //    public int MyProperty { get; set; }
    //}
}
