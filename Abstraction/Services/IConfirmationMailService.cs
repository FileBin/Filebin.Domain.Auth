namespace Filebin.Domain.Auth.Abstraction.Services;

public interface IConfirmationMailService : IMailService {
    public Task SendConfirmationEmailAsync(string userEmail, string userId, string confirmationLink);
}
