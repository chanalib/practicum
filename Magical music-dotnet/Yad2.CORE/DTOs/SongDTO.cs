using System;
using System.ComponentModel.DataAnnotations;

namespace MagicalMusic.CORE.DTOs
{
    public class SongDTO
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string MusicStyle { get; set; }

        public TimeSpan SongLength { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ImageUrl { get; set; }

        public int CreatorId { get; set; }
    }
}
