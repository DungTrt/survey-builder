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
    public class AccountSurveyAnswerService : IAccountSurveyAnswerService
    {
        private readonly IAccountSurveyAnswerRepository accountSurveyAnswerRepository;
        private readonly IMapper mapper;
        public AccountSurveyAnswerService(IAccountSurveyAnswerRepository _accountSurveyAnswerRepository, IMapper _mapper)
        {
            accountSurveyAnswerRepository = _accountSurveyAnswerRepository;
            mapper = _mapper;
        }

        public Task<ApiResponse> CreateAsync(InsertAccountSurveyAnswerDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> CreateListAsync(IEnumerable<InsertAccountSurveyAnswerDTO> objs)
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

        public Task<ApiResponse> UpdateAsync(UpdateAccountSurveyAnswerDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UpdateListAsync(IEnumerable<UpdateAccountSurveyAnswerDTO> obj)
        {
            throw new NotImplementedException();
        }
    }
}
