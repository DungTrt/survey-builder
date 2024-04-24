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
    public class UploadAnswerHistoryService : IUploadAnswerHistoryService
    {
        private readonly IUploadAnswerHistoryRepository uploadAnswerHistoryRepository;
        private readonly IMapper mapper;
        public UploadAnswerHistoryService(IUploadAnswerHistoryRepository _uploadAnswerHistoryRepository, IMapper _mapper)
        {
            uploadAnswerHistoryRepository = _uploadAnswerHistoryRepository;
            mapper = _mapper;
        }

        public Task<ApiResponse> CreateAsync(InsertUploadAnswerHistoryDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> CreateListAsync(IEnumerable<InsertUploadAnswerHistoryDTO> objs)
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

        public Task<ApiResponse> UpdateAsync(UpdateUploadAnswerHistoryDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UpdateListAsync(IEnumerable<UpdateUploadAnswerHistoryDTO> obj)
        {
            throw new NotImplementedException();
        }
    }
}
