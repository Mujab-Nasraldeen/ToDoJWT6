﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using ToDoJWT6.Models;

namespace ToDoJWT.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }
        public List<RefreshToken>? RefreshTokens { get; set; }
    }
}
