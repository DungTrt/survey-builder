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
    public class UploadBillHistoryService : IUploadBillHistoryService
    {
        private readonly IUploadBillHistoryRepository uploadBillHistoryRepository;
        private readonly IMapper mapper;
        public UploadBillHistoryService(IUploadBillHistoryRepository _uploadBillHistoryRepository, IMapper _mapper)
        {
            uploadBillHistoryRepository = _uploadBillHistoryRepository;
            mapper = _mapper;
        }

        public Task<ApiResponse> CreateAsync(InsertUploadBillHistoryDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> CreateListAsync(IEnumerable<InsertUploadBillHistoryDTO> objs)
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

        public Task<ApiResponse> UpdateAsync(UpdateUploadBillHistoryDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UpdateListAsync(IEnumerable<UpdateUploadBillHistoryDTO> obj)
        {
            throw new NotImplementedException();
        }
    }
}
