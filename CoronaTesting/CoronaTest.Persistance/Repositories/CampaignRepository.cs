using CoronaTest.Core.Contracts;
using CoronaTest.Core.DataTransferObjects;
using CoronaTest.Core.Entities;
using CoronaTest.Persistance;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaTest.Persistence.Repositories
{
    public class CampaignRepository : ICampaignRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CampaignRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Campaign campaign)
            => await _dbContext
                .Campaigns
                .AddAsync(campaign);

        public async Task AddRangeAsync(Campaign[] campaigns)
            => await _dbContext
                .Campaigns
                .AddRangeAsync(campaigns);

        public async Task<CampaignDto[]> GetAllAsync()
            => await _dbContext
                .Campaigns
                .Select(c => new CampaignDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    From = c.From,
                    To = c.To
                })
                .OrderBy(c => c.Name)
                .ToArrayAsync();

        public async Task<CampaignDto> GetDtoByIdAsync(int id)
            => await _dbContext
                .Campaigns
                .Select(c => new CampaignDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    From = c.From,
                    To = c.To
                })
                .SingleOrDefaultAsync(c => c.Id == id);

        public async Task<int> GetCountAsync()
            => await _dbContext
                .Campaigns
                .CountAsync();

        public void Remove(Campaign campaign)
        => _dbContext.Remove(campaign);

        public void Update(Campaign modifiedCampaign)
        => _dbContext.Campaigns.Update(modifiedCampaign);

        public async Task<Campaign> GetByIdAsync(int id)
        => await _dbContext.Campaigns.SingleOrDefaultAsync(c => c.Id == id);
    }
}
