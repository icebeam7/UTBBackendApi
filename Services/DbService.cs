using Microsoft.EntityFrameworkCore;
using UTBBackendApi.Context;

namespace UTBBackendApi.Services
{
    public class DbService : IDbService
    {
        UTBDbContext db;

        public DbService(UTBDbContext db)
        {
            this.db = db;
        }

        public async Task<List<T>> GetAll<T>() where T : class
        {
            return await db.Set<T>().ToListAsync();
        }

        public async Task<T> Get<T>(int id) where T : class
        {
            return await db.Set<T>().FindAsync(id);
        }

        public async Task Add<T>(T newData)
        {
            await db.AddAsync(newData);
            await db.SaveChangesAsync();
        }
    }
}
