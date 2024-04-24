using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Core.Entities
{
    public class PagingData<T>
    {
        public T DataSource { get; set; }
        public long Total { get; set; }
        public long TotalFiltered { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalFiltered / (double)PageSize);
        public int PageSize { get; set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
        public long FirstRowOnPage => Total > 0 ? (TotalFiltered > 0 ? (CurrentPage - 1) * PageSize + 1 : 0) : 0;
        public long LastRowOnPage => Math.Min(CurrentPage * PageSize, TotalFiltered);
        public string PageInfo => $"Showing  {FirstRowOnPage} to {LastRowOnPage} of {TotalFiltered} entries  " + (Total > TotalFiltered ? $"(filtered from {Total} total entries)" : "");
    }
}
