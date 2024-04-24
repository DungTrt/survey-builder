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
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository roleRepository;
        private readonly IMapper mapper;
        public RoleService(IRoleRepository _roleRepository, IMapper _mapper)
        {
            roleRepository = _roleRepository;
            mapper = _mapper;
        }

        public Task<ApiResponse> CreateAsync(InsertRoleDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> CreateListAsync(IEnumerable<InsertRoleDTO> objs)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> SoftDeleteListAsync(IEnumerable<int> objs)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UpdateAsync(UpdateRoleDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UpdateListAsync(IEnumerable<UpdateRoleDTO> obj)
        {
            throw new NotImplementedException();
        }
    }
}
