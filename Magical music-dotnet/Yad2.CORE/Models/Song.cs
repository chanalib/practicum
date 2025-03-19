using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicalMusic.CORE.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; } // Foreign key for user
        public int AlbumId { get; set; } // Foreign key for album

        
        public string Creator { get; set; }

      
        public string FileType { get; set; }

        public DateTime CreatedAt { get; set; } 


        public List<Album> Products { get; set; } 
    }
}
