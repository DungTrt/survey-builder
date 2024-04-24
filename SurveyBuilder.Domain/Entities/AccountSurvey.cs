using SurveyBuilder.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Domain.Entities
{
    public class AccountSurvey : EntityBase<long>
    {
        public long AccountId { get; set; }
        public long SurveyId { get; set; }
        public virtual Account Account { get; }
        public virtual Survey Survey { get; }
        public virtual ICollection<AccountSurveyAnswer> AccountSurveyAnswers { get; } = new List<AccountSurveyAnswer>();
        public virtual ICollection<Orders> Orders { get; } = new List<Orders>();
    }
}
