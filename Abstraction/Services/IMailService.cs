namespace Filebin.Domain.Auth.Abstraction.Services;
public interface IMailService {
    public Task SendEmailAsync(string destination, string subject, string message);
}
