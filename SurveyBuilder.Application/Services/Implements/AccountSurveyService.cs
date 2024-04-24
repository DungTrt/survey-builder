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
    public class AccountSurveyService : IAccountSurveyService
    {
        private readonly IAccountSurveyRepository accountSurveyRepository;
        private readonly IMapper mapper;
        public AccountSurveyService(IAccountSurveyRepository _accountSurveyRepository, IMapper _mapper)
        {
            accountSurveyRepository = _accountSurveyRepository;
            mapper = _mapper;
        }

        public Task<ApiResponse> CreateAsync(InsertAccountSurveyDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> CreateListAsync(IEnumerable<InsertAccountSurveyDTO> objs)
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

        public Task<ApiResponse> UpdateAsync(UpdateAccountSurveyDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UpdateListAsync(IEnumerable<UpdateAccountSurveyDTO> obj)
        {
            throw new NotImplementedException();
        }
    }
}
