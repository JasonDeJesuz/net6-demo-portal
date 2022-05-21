using sheeple.Data.Authentication;
using sheeple.Shared.DTO.Auth;
using Microsoft.AspNetCore.Identity;

namespace sheeple.Core.Services.UserAuthenticationService
{
    public interface IUserAuthenticationService
    {
        Task<IdentityResult> RegisterUserAsync(UserRegistrationDto userForRegistration);
        Task<IdentityResult> RegisterAdminAsync(UserRegistrationDto userfouserForRegistration);
        Task<bool> ValidateUserAsync(LoginDto loginDto);
        bool ValidateToken(string token);
        Task<string> CreateTokenAsync();
    }
}
