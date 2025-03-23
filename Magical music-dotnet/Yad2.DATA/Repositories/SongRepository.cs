using MagicalMusic.CORE.Models;
using MagicalMusic.CORE.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MagicalMusic.CORE;
using MagicalMusic.DATA;


namespace MagicalMusic.DATA.Repositories
{
    public class SongRepository : ISongRepository
    {
        private readonly DataContext _context;
        public SongRepository(DataContext context) { _context = context; }

        public async Task<IEnumerable<Song>> GetAllAsync() => await _context.Songs.Include(s => s.Creator).Include(s => s.Users).ToListAsync();

        public async Task<Song> GetByIdAsync(int id) => await _context.Songs.FindAsync(id);

        public async Task<IEnumerable<Song>> GetSongsByGenreAsync(string MusicStyle) => await _context.Songs.Where(s => s.MusicStyle == MusicStyle).ToListAsync();

        public async Task<Song> AddAsync(Song song)
        {
          

            await _context.Songs.AddAsync(song);
            await _context.SaveChangesAsync();
            return song;
        }


        public async Task<Song> UpdateAsync(int id, Song song)
        {
            Song s = await _context.Songs.SingleOrDefaultAsync(act => act.Id == id);
            if (s == null) return null;
            else
            {

                s.Name = song.Name;
                s.MusicStyle = song.MusicStyle;
                s.SongLength = song.SongLength;
                s.ImageUrl = song.ImageUrl;
                s.ReleaseDate = song.ReleaseDate;
                s.Creator = song.Creator;
                s.creatorId = song.creatorId;
               // s.SingerId = song.SingerId;
                //s.User = song.User;

            }
            await _context.SaveChangesAsync();
            return s;

        }

        public async Task DeleteAsync(int id) { var entity = await _context.Songs.FindAsync(id); if (entity != null) { _context.Songs.Remove(entity); await _context.SaveChangesAsync(); } }
    }
}
