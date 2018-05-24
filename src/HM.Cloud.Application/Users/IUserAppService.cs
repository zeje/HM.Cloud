using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HM.Cloud
{
    public interface IUserAppService : IApplicationService
    {
        Task<ListResultDto<UserListDto>> GetAll(GetAllUsersInput input);
    }
}
