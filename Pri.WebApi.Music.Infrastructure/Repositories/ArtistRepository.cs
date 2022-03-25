using Microsoft.EntityFrameworkCore;
using Pri.Oe.WebApi.Music.Infrastructure.Data;
using Pri.Oe.WebApi.Music.Core.Entities;
using Pri.Oe.WebApi.Music.Core.Repositories.Interfaces;
using System.Linq;
using Pri.Oe.WebApi.Music.Infrastructure.Repositories;

namespace Pri.Oe.WebApi.Music.Api.Repositories
{
    public class ArtistRepository : BaseRepository<Artist>, IArtistepository
    {
        public ArtistRepository(MusicDbContext dbContext) : base(dbContext)
        {

        }

        public override IQueryable<Artist> GetAll()
        {
            return _dbContext.Artists.Include(a => a.Albums).AsQueryable();
        }
    }
}
