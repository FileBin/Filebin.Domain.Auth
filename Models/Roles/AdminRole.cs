using Microsoft.AspNetCore.Identity;

namespace Filebin.Common.Data.Roles;

public class AdminRole : IdentityRole {
    public static readonly string RoleName = "admin";
    public static readonly string AdminUsername = "admin";
    public static readonly string AdminEmail = "admin@email.com";

    public AdminRole() : base(RoleName) { }
}