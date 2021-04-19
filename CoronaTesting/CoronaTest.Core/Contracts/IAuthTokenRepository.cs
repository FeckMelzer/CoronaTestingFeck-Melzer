using CoronaTest.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoronaTest.Core.Contracts
{
    public interface IAuthTokenRepository
    {
        Task<AuthToken> GetTokenByIdentifierAsync(Guid identifier);
        Task AddAsync(AuthToken token);
    }
}
