using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicalMusic.CORE.Models
{
    public class Creator
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Song> Songs { get; set; }
    }
}

