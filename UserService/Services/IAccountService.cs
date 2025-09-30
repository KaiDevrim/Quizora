using Microsoft.AspNetCore.Identity;
using Shared.Models;

namespace UserService.Services;

public interface IAccountService
{
    Task<IdentityResult> RegisterUserAsync(User user, string password);
    Task<IdentityResult> ConfirmEmailAsync(User user, string token);
    
    Task<SignInResult> LoginUserAsync(User user, string password);
    Task LogoutUserAsync();
    Task SendEmailConfirmationAsync(User user);
    Task SendPasswordResetAsync(User user);
}