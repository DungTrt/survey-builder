using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Core.Entities
{
    public class AdvancedSearchQuery<T>:SearchQuery
    {
        public T SearchOptions { get; set; }
    }
}
