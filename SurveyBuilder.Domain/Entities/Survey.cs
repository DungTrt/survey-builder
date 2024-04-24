using SurveyBuilder.Core.Entities;
using SurveyBuilder.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Domain.Entities
{
    public class Survey : EntityFullTextSearch<long>
    {
        public DateTime? StartTime { get; set; }
        public long AccountId { get; set; }
        public virtual Account Account { get; }
        public ICollection<Question> Questions { get; } = new List<Question>();
        public ICollection<AccountSurvey> AccountSurveys { get; } = new List<AccountSurvey>();
    }
}
