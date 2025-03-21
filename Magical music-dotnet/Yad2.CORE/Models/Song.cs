using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicalMusic.CORE.Models
{
    public class Song
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public string MusicStyle { get; set; }

        public TimeSpan SongLength { get; set; }
       // public string Creator { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ImageUrl { get; set; }

       // public int SingerId { get; set; } //לבדוק למה?
        public Creator Creator { get; set; }

        public List<User> Users { get; set; }//לבדוק למה?

    }
}
