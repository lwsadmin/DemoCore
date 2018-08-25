using System.Collections.Generic;
using DemoCore.Roles.Dto;
using DemoCore.Users.Dto;

namespace DemoCore.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
