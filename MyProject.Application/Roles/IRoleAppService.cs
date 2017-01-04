using System.Threading.Tasks;
using Abp.Application.Services;
using MyProject.Roles.Dto;

namespace MyProject.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
