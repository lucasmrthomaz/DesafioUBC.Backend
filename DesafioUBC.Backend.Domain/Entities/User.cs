﻿using System.ComponentModel.DataAnnotations;

namespace DesafioUBC.Backend.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
