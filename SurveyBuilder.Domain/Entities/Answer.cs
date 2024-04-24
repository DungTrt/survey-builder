using SurveyBuilder.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Domain.Entities
{
    public class Answer: EntityFullTextSearch<long>
    {
        public int QuestionId { get; set; }
        public decimal Price { get; set; }
        public virtual Question Question { get; }
        public virtual ICollection<AccountSurveyAnswer> AccountSurveyAnswers { get;}=new List<AccountSurveyAnswer>();
    }
}
