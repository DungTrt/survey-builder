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
    public class QuestionTypeService : IQuestionTypeService
    {
        private readonly IQuestionTypeRepository questionTypeRepository;
        private readonly IMapper mapper;
        public QuestionTypeService(IQuestionTypeRepository _questionTypeRepository, IMapper _mapper)
        {
            questionTypeRepository = _questionTypeRepository;
            mapper = _mapper;
        }

        public Task<ApiResponse> CreateAsync(InsertQuestionTypeDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> CreateListAsync(IEnumerable<InsertQuestionTypeDTO> objs)
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

        public Task<ApiResponse> UpdateAsync(UpdateQuestionTypeDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UpdateListAsync(IEnumerable<UpdateQuestionTypeDTO> obj)
        {
            throw new NotImplementedException();
        }
    }
}
