using AutoMapper;
using SurveyBuilder.Application.Models;
using SurveyBuilder.Application.Services.Interfaces;
using SurveyBuilder.Core.Entities;
using SurveyBuilder.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Application.Services.Implements
{
    public class AccountRoleService : IAccountRoleService
    {
        private readonly IAccountRoleRepository accountRoleRepository;
        private readonly IMapper mapper;
        public AccountRoleService(IAccountRoleRepository _accountRoleRepository, IMapper _mapper)
        {
            accountRoleRepository = _accountRoleRepository;
            mapper = _mapper;
        }
        public Task<ApiResponse> CreateAsync(InsertAccountRoleDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> CreateListAsync(IEnumerable<InsertAccountRoleDTO> objs)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> SoftDeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> SoftDeleteListAsync(IEnumerable<long> objs)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UpdateAsync(UpdateAccountRoleDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UpdateListAsync(IEnumerable<UpdateAccountRoleDTO> obj)
        {
            throw new NotImplementedException();
        }
    }
}
