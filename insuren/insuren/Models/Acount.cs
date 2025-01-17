﻿using Microsoft.AspNetCore.Identity;

namespace insuren.Models
{
    public class Acount
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
    public enum Role
    {
        Admin, User
    }
}
