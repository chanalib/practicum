using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicalMusic.CORE.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Creator { get; set; }


        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CreationDate { get; set; }

    }
}
