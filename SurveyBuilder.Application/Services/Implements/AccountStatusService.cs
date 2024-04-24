using AutoMapper;
using SurveyBuilder.Application.Models;
using SurveyBuilder.Application.Services.Interfaces;
using SurveyBuilder.Core.Entities;
using SurveyBuilder.Core.Utilities;
using SurveyBuilder.Domain.Entities;
using SurveyBuilder.Infrastructure.Repositories.Implements;
using SurveyBuilder.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Application.Services.Implements
{
    public class AccountStatusService : IAccountStatusService
    {
        private readonly IAccountStatusRepository accountStatusRepository;
        private readonly IMapper mapper;
        public AccountStatusService(IAccountStatusRepository _accountStatusRepository, IMapper _mapper)
        {
            accountStatusRepository = _accountStatusRepository;
            mapper = _mapper;
        }
        public async Task<ApiResponse> CreateAsync(InsertAccountStatusDTO obj)
        {
            var model = mapper.Map<AccountStatus>(obj);

            model.Id = 0;
            model.Active = true;
            model.CreatedTime = DateTime.UtcNow;
            model.Description = string.IsNullOrEmpty(model.Description) ? null : model.Description.ToEscape();

            var listErrors = new List<string>();
            bool isNameExisted = await accountStatusRepository
                .AnyAsync(x => x.Active && x.Id != model.Id && x.Name.Trim() == model.Name.Trim().ToLower());
            if (isNameExisted)
            {
                listErrors.Add("Name is existed.");
            }

            bool isColorExisted = await accountStatusRepository
                .AnyAsync(x => x.Active && x.Id != model.Id && x.Name.Trim() == model.Name.Trim().ToLower());
            if (isColorExisted)
            {
                listErrors.Add("Color is existed.");
            }

            if (listErrors.Count > 0)
            {
                return ApiResponse.BadRequest(listErrors);
            }

            await accountStatusRepository.CreateAsync(model);
            await accountStatusRepository.SaveChangesAsync();

            return ApiResponse.Created(model);
        }

        public Task<ApiResponse> CreateListAsync(IEnumerable<InsertAccountStatusDTO> objs)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse> GetAllAsync()
        {
            var data = await accountStatusRepository.FindByConditionAsync(x => x.Active);
            var objs = mapper.Map<List<AccountStatusDTO>>(data);
            return ApiResponse.Success(objs);
        }

        public async Task<ApiResponse> GetByIdAsync(int id)
        {
            var obj = await accountStatusRepository.GetByIdAsync(id);
            var result = mapper.Map<AccountStatusDTO>(obj);
            return ApiResponse.Success(result);
        }

        public async Task<ApiResponse> SoftDeleteAsync(int id)
        {
            var result = await accountStatusRepository.SoftDeleteAsync(id);
            if (result)
            {
                await accountStatusRepository.SaveChangesAsync();
                return ApiResponse.Success();
            }
            return ApiResponse.NotFound(result);
        }

        public Task<ApiResponse> SoftDeleteListAsync(IEnumerable<int> objs)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse> UpdateAsync(UpdateAccountStatusDTO obj)
        {
            var accountStatus = await accountStatusRepository.GetByIdAsync(obj.Id);
            if (accountStatus == null)
            {
                return ApiResponse.NotFound(accountStatus);
            }

            var updateAccountStatus = mapper.Map(obj, accountStatus);
            updateAccountStatus.Description = string.IsNullOrEmpty(updateAccountStatus.Description) ? null : updateAccountStatus.Description.ToEscape();

            var listErrors = new List<string>();
            bool isNameExisted = await accountStatusRepository
                .AnyAsync(x => x.Active && x.Id != obj.Id && x.Name.Trim() == obj.Name.Trim().ToLower());
            if (isNameExisted)
            {
                listErrors.Add("Name is existed.");
            }

            bool isColorExisted = await accountStatusRepository
                .AnyAsync(x => x.Active && x.Id != obj.Id && x.Name.Trim() == obj.Name.Trim().ToLower());
            if (isColorExisted)
            {
                listErrors.Add("Color is existed.");
            }

            if (listErrors.Count > 0)
            {
                return ApiResponse.BadRequest(listErrors);
            }

            await accountStatusRepository.UpdateAsync(updateAccountStatus);
            await accountStatusRepository.SaveChangesAsync();
            return ApiResponse.Success(obj);
        }

        public Task<ApiResponse> UpdateListAsync(IEnumerable<UpdateAccountStatusDTO> obj)
        {
            throw new NotImplementedException();
        }
    }
}
