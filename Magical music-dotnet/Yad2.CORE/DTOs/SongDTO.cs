using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicalMusic.CORE.Models;

namespace MagicalMusic.CORE.DTOs
{
    public class SongDTO
    {
       
        public string Name { get; set; }

        public string MusicStyle { get; set; }

        public TimeSpan SongLength { get; set; }
        // public string Creator { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ImageUrl { get; set; }

        // public int SingerId { get; set; } //לבדוק למה?
        public Creator Creator { get; set; }//אולי להחליף ל-רק איידי

        public List<User> Users { get; set; }//לבדוק למה?

    }
}
