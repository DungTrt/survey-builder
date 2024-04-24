using SurveyBuilder.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Core.Services
{
    /// <summary>
    /// Interface service base
    /// </summary>
    /// <typeparam name="T">Type of id column</typeparam>
    /// <typeparam name="K">Insert DTO</typeparam>
    /// <typeparam name="L">Update DTO</typeparam>
    /// <typeparam name="J">Detail DTO</typeparam>
    public interface IServiceQueryBase<T, K, L, J> where K : class where L : class where J : class
    {
        Task<ApiResponse> GetByIdAsync(T id);
        Task<ApiResponse> CreateAsync(K obj);
        Task<ApiResponse> CreateListAsync(IEnumerable<K> objs);
        Task<ApiResponse> UpdateAsync(L obj);
        Task<ApiResponse> UpdateListAsync(IEnumerable<L> obj);
        Task<ApiResponse> SoftDeleteAsync(T id);
        Task<ApiResponse> SoftDeleteListAsync(IEnumerable<T> objs);
        Task<ApiResponse> GetAllAsync();
    }
}
