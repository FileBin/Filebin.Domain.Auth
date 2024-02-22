using Filebin.Domain.Auth.Abstraction;

namespace Filebin.Common.Models.Auth;

public class LoginResultDto : ITokenPair {
    public required string AccessToken { get; set; }
    public required string RefreshToken { get; set; }
}
