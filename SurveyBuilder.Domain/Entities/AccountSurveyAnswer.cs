using SurveyBuilder.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Domain.Entities
{
    public class AccountSurveyAnswer : EntityBase<long>
    {
        public long AccountSurveyId { get; set; }
        public long AnswerId { get; set; }
        public virtual Answer Answer { get; }
        public virtual AccountSurvey AccountSurvey{get;}
    }
}
