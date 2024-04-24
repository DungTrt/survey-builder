using SurveyBuilder.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Domain.Entities
{
    public class QuestionType:EntityCommon<int>
    {
        public virtual ICollection<Question> Questions { get; } = new List<Question>();
    }
}
