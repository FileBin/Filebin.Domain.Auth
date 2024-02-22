namespace Filebin.Domain.Auth.Abstraction;

public interface IUserDescriptor {
    string UserId { get; }
    bool IsAdmin { get; }
}