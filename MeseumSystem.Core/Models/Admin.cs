﻿using System.ComponentModel.DataAnnotations;

namespace MuseumSystem.Core.Models
{
    public class Admin
    {
        [Key]
        public int IdAdmin { get; set; }

        public string Login { get; set; }

        public string HashPassword {  get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public int MuseumId { get; set; }
        public Museum Museum { get; set; }
    }
}
