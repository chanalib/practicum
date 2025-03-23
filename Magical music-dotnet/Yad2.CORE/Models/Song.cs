using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MagicalMusic.CORE.Models
{
    public class Song
    {
       

        public int Id { get; set; }

       
        public string Name { get; set; }

        public string MusicStyle { get; set; }

        public TimeSpan SongLength { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ImageUrl { get; set; }
        public int creatorId { get; set; }

        public Creator Creator { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
