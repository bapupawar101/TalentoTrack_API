﻿using System.ComponentModel.DataAnnotations.Schema;

namespace TalentoTrack.Common.Entities
{
    public class LoginDetails
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool IsBlocked { get; set; }

        [ForeignKey("UserId")]
        public virtual User? User { get; set; }
    }
}
