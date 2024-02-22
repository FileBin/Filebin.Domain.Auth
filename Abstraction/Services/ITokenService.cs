using Microsoft.AspNetCore.Identity;

namespace Filebin.Domain.Auth.Abstraction.Services;

public interface ITokenService {
    Task<ITokenPair> GenerateTokenAsync(IdentityUser user);
}

