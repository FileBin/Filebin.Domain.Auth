namespace Filebin.Domain.Auth.Abstraction;

public interface ITokenPair {
    string AccessToken { get; }
    string RefreshToken { get; }
}