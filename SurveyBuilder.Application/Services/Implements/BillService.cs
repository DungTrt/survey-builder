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
    internal class BillService : IBillService
    {
        private readonly IBillRepository billRepository;
        private readonly IMapper mapper;
        public BillService(IBillRepository _billRepository, IMapper _mapper)
        {
            billRepository = _billRepository;
            mapper = _mapper;
        }

        public Task<ApiResponse> CreateAsync(InsertBillDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> CreateListAsync(IEnumerable<InsertBillDTO> objs)
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

        public Task<ApiResponse> UpdateAsync(UpdateBillDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UpdateListAsync(IEnumerable<UpdateBillDTO> obj)
        {
            throw new NotImplementedException();
        }
    }
}
