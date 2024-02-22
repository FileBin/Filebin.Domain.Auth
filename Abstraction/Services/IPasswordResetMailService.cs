namespace Filebin.Domain.Auth.Abstraction.Services;
public interface IPasswordResetMailService : IMailService {
    public Task SendPasswordResetEmailAsync(string userEmail, string userId, string passwordResetLink);
}
