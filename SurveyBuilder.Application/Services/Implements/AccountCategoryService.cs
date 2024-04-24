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
    public class AccountCategoryService : IAccountCategoryService
    {
        private readonly IAccountCategoryRepository accountCategoryRepository;
        private readonly IMapper mapper;
        public AccountCategoryService(IAccountCategoryRepository _accountCategoryRepository, IMapper _mapper)
        {
            accountCategoryRepository = _accountCategoryRepository;
            mapper = _mapper;
        }
        public async Task<ApiResponse> CreateAsync(InsertAccountCategoryDTO obj)
        {
            var model = mapper.Map<AccountCategory>(obj);

            model.Id = 0;
            model.Active = true;
            model.CreatedTime = DateTime.UtcNow;
            model.Description = string.IsNullOrEmpty(model.Description) ? null : model.Description.ToEscape();

            var listErrors = new List<string>();
            bool isNameExisted = await accountCategoryRepository
                .AnyAsync(x => x.Active && x.Id != model.Id && x.Name.Trim() == model.Name.Trim().ToLower());
            if (isNameExisted)
            {
                listErrors.Add("Name is existed.");
            }

            bool isColorExisted = await accountCategoryRepository
                .AnyAsync(x => x.Active && x.Id != model.Id && x.Name.Trim() == model.Name.Trim().ToLower());
            if (isColorExisted)
            {
                listErrors.Add("Color is existed.");
            }

            if (listErrors.Count > 0)
            {
                return ApiResponse.BadRequest(listErrors);
            }

            await accountCategoryRepository.CreateAsync(model);
            await accountCategoryRepository.SaveChangesAsync();

            return ApiResponse.Created(model);
        }

        public Task<ApiResponse> CreateListAsync(IEnumerable<InsertAccountCategoryDTO> objs)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse> GetAllAsync()
        {
            var data = await accountCategoryRepository.FindByConditionAsync(x => x.Active);
            var objs = mapper.Map<List<AccountCategoryDTO>>(data);
            return ApiResponse.Success(objs);
        }

        public async Task<ApiResponse> GetByIdAsync(int id)
        {
            var obj = await accountCategoryRepository.GetByIdAsync(id);
            var result = mapper.Map<AccountCategoryDTO>(obj);
            return ApiResponse.Success(result);
        }

        public async Task<ApiResponse> SoftDeleteAsync(int id)
        {
            var result = await accountCategoryRepository.SoftDeleteAsync(id);
            if (result)
            {
                await accountCategoryRepository.SaveChangesAsync();
                return ApiResponse.Success();
            }
            return ApiResponse.NotFound(result);
        }

        public Task<ApiResponse> SoftDeleteListAsync(IEnumerable<int> objs)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse> UpdateAsync(UpdateAccountCategoryDTO obj)
        {
            var accountCategory = await accountCategoryRepository.GetByIdAsync(obj.Id);
            if (accountCategory == null)
            {
                return ApiResponse.NotFound(accountCategory);
            }

            var updateAccountCategory = mapper.Map(obj, accountCategory);
            updateAccountCategory.Description = string.IsNullOrEmpty(updateAccountCategory.Description) ? null : updateAccountCategory.Description.ToEscape();

            var listErrors = new List<string>();
            bool isNameExisted = await accountCategoryRepository
                .AnyAsync(x => x.Active && x.Id != obj.Id && x.Name.Trim() == obj.Name.Trim().ToLower());
            if (isNameExisted)
            {
                listErrors.Add("Name is existed.");
            }

            bool isColorExisted = await accountCategoryRepository
                .AnyAsync(x => x.Active && x.Id != obj.Id && x.Name.Trim() == obj.Name.Trim().ToLower());
            if (isColorExisted)
            {
                listErrors.Add("Color is existed.");
            }

            if (listErrors.Count > 0)
            {
                return ApiResponse.BadRequest(listErrors);
            }

            await accountCategoryRepository.UpdateAsync(updateAccountCategory);
            await accountCategoryRepository.SaveChangesAsync();
            return ApiResponse.Success(obj);
        }

        public Task<ApiResponse> UpdateListAsync(IEnumerable<UpdateAccountCategoryDTO> obj)
        {
            throw new NotImplementedException();
        }
    }
}
