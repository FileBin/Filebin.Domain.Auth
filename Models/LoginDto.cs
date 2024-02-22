using System.Text.Json.Serialization;

namespace Filebin.Common.Models.Auth;

public class LoginDto {
    [JsonConstructor]
    public LoginDto(string login, string password) {
        Login = login;
        Password = password;
    }

    public LoginDto(LoginDto other) {
        Login = other.Login;
        Password = other.Password;
    }
    public string Login { get; set; }
    public string Password { get; set; }
}
