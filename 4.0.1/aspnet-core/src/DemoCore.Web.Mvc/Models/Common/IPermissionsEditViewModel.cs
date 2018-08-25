using System.Collections.Generic;
using DemoCore.Roles.Dto;

namespace DemoCore.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}