using Microsoft.EntityFrameworkCore;

using web_layer.Entity;

namespace web_layer.Service
{
    public class ProviderService : IProviderService
    {
        private ApplicationDbContext dbContext;

        public ProviderService(ApplicationDbContext dbContext)
        {
            ArgumentNullException.ThrowIfNull(dbContext, nameof(dbContext));

            this.dbContext = dbContext;
        }

        public List<ProviderEntity> GetProviders()
        {
            return dbContext.Providers.ToList();
        }
    }
}
