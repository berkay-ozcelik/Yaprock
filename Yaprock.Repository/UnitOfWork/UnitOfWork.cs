using Yaprock.Core.UnitOfWork;
using Yaprock.Repository.DbContext;

namespace Yaprock.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly YaprockDbContext _context;

        public UnitOfWork(YaprockDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
