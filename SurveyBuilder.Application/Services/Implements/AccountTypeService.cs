using AutoMapper;
using SurveyBuilder.Application.Models;
using SurveyBuilder.Application.Services.Interfaces;
using SurveyBuilder.Core.Entities;
using SurveyBuilder.Core.Utilities;
using SurveyBuilder.Domain.Entities;
using SurveyBuilder.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Application.Services.Implements
{
    public class AccountTypeService : IAccountTypeService
    {
        private readonly IAccountTypeRepository accountTypeRepository;
        private readonly IMapper mapper;
        public AccountTypeService(IAccountTypeRepository _accountTypeRepository, IMapper _mapper)
        {
            accountTypeRepository = _accountTypeRepository;
            mapper = _mapper;
        }

        public async Task<ApiResponse> CreateAsync(InsertAccountTypeDTO obj)
        {
            var model = mapper.Map<AccountType>(obj);

            model.Id = 0;
            model.Active = true;
            model.CreatedTime = DateTime.UtcNow;
            model.Description = string.IsNullOrEmpty(model.Description) ? null : model.Description.ToEscape();

            var listErrors = new List<string>();
            bool isNameExisted = await accountTypeRepository
                .AnyAsync(x => x.Active && x.Id != model.Id && x.Name.Trim() == model.Name.Trim().ToLower());
            if (isNameExisted)
            {
                listErrors.Add("Name is existed.");
            }
            if (listErrors.Count > 0)
            {
                return ApiResponse.BadRequest(listErrors);
            }

            await accountTypeRepository.CreateAsync(model);
            await accountTypeRepository.SaveChangesAsync();

            return ApiResponse.Created(model);
        }

        public Task<ApiResponse> CreateListAsync(IEnumerable<InsertAccountTypeDTO> objs)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse> GetAllAsync()
        {
            var data = await accountTypeRepository.FindByConditionAsync(x => x.Active);
            var objs = mapper.Map<List<AccountTypeDTO>>(data);
            return ApiResponse.Success(objs);
        }

        public async Task<ApiResponse> GetByIdAsync(int id)
        {
            var obj = await accountTypeRepository.GetByIdAsync(id);
            var result = mapper.Map<AccountTypeDTO>(obj);
            return ApiResponse.Success(result);
        }

        public async Task<ApiResponse> SoftDeleteAsync(int id)
        {
            var result = await accountTypeRepository.SoftDeleteAsync(id);
            if (result)
            {
                await accountTypeRepository.SaveChangesAsync();
                return ApiResponse.Success();
            }
            return ApiResponse.NotFound(result);
        }

        public Task<ApiResponse> SoftDeleteListAsync(IEnumerable<int> objs)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse> UpdateAsync(UpdateAccountTypeDTO obj)
        {
            var accounType = await accountTypeRepository.GetByIdAsync(obj.Id);
            if (accounType == null)
            {
                return ApiResponse.NotFound(accounType);
            }

            var updateAccountType = mapper.Map(obj, accounType);
            updateAccountType.Description = string.IsNullOrEmpty(updateAccountType.Description) ? null : updateAccountType.Description.ToEscape();

            var listErrors = new List<string>();
            bool isNameExisted = await accountTypeRepository
                .AnyAsync(x => x.Active && x.Id != obj.Id && x.Name.Trim() == obj.Name.Trim().ToLower());
            if (isNameExisted)
            {
                listErrors.Add("Name is existed.");
            }
            if (listErrors.Count > 0)
            {
                return ApiResponse.BadRequest(listErrors);
            }

            await accountTypeRepository.UpdateAsync(updateAccountType);
            await accountTypeRepository.SaveChangesAsync();
            return ApiResponse.Success(obj);
        }

        public Task<ApiResponse> UpdateListAsync(IEnumerable<UpdateAccountTypeDTO> obj)
        {
            throw new NotImplementedException();
        }
    }
}
