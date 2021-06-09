using System.Threading.Tasks;
using API.Entities;
using System.Collections.Generic;
using API.DTOs;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);

        Task<bool> SaveAllAsync();

        Task<IEnumerable<AppUser>> GetUserAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUserNameAsync(string username);

        Task<IEnumerable<memberDto>> GetMembersAsync();

        Task<memberDto> GetMemberAsync(string username);

        
    }
}