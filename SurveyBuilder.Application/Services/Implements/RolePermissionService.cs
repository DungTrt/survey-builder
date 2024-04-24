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
    public class RolePermissionService : IRolePermissionService
    {
        private readonly IRolePermissionRepository rolePermissionRepository;
        private readonly IMapper mapper;
        public RolePermissionService(IRolePermissionRepository _rolePermissionRepository, IMapper _mapper)
        {
            rolePermissionRepository = _rolePermissionRepository;
            mapper = _mapper;
        }

        public Task<ApiResponse> CreateAsync(InsertRolePermissionDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> CreateListAsync(IEnumerable<InsertRolePermissionDTO> objs)
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

        public Task<ApiResponse> UpdateAsync(UpdateRolePermissionDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UpdateListAsync(IEnumerable<UpdateRolePermissionDTO> obj)
        {
            throw new NotImplementedException();
        }
    }
}
