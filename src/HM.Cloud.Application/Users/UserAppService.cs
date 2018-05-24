//using Abp.Application.Services;
//using Abp.Application.Services.Dto;
//using Abp.Collections.Extensions;
//using Abp.Linq.Extensions;
//using Microsoft.EntityFrameworkCore;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;

namespace HM.Cloud
{
    public class UserAppService : CloudAppServiceBase, IUserAppService
    {
        private readonly IRepository<User,Guid> _userRepository;

        public UserAppService(IRepository<User, Guid> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ListResultDto<UserListDto>> GetAll(GetAllUsersInput input)
        {
            var users = await _userRepository
                .GetAll()
                .WhereIf(input.UserStatus.HasValue, t => t.UserStatus == input.UserStatus.Value)
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<UserListDto>(
                ObjectMapper.Map<List<UserListDto>>(users)
            );
        }
    }
}
