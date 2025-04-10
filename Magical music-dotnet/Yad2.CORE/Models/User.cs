﻿using System.ComponentModel.DataAnnotations;

namespace MagicalMusic.CORE.Models
{
    public class User
    {
        
        public int Id { get; set; }
       
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
      
        public string Role { get; set; }
        public ICollection<Song> Songs { get; set; } // קשרים לשירים


    }
}
