using System.Security.Claims;
using Filebin.Common.Data.Roles;
using Filebin.Domain.Auth.Abstraction;

namespace Filebin.Common.Models.Auth;

public class ClaimUserDescriptor : IUserDescriptor {
    public required ClaimsPrincipal User { get; init; }

    public static ClaimUserDescriptor From(ClaimsPrincipal user) {
        return new ClaimUserDescriptor() { User = user };
    }

    public string UserId
        => User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).FirstOrDefault()?.Value!;

    public bool IsAdmin => User.IsInRole(AdminRole.RoleName);
}