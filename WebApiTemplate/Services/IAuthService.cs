using WebApiTemplate.DTOs;

namespace WebApiTemplate.Services
{
    public interface IAuthService
    {
        Task<AuthResponseDto?> RegisterAsync(RegisterDto registerDto);
        Task<AuthResponseDto?> LoginAsync(LoginDto loginDto);
        Task<bool> AssignRoleAsync(AssignRoleDto assignRoleDto);
        Task<bool> CreateRoleAsync(string roleName);
        Task<IEnumerable<string>> GetRolesAsync();
        Task<UserDto?> GetUserByIdAsync(string userId);
        Task<IEnumerable<UserDto>> GetUsersAsync();
    }
}