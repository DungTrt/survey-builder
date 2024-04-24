using SurveyBuilder.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Domain.Entities
{
    public class Question : EntityFullTextSearch<long>
    {
        public int QuestionTypeId { get; set; }
        public long SurveyId { get; set; }
        public virtual QuestionType QuestionType { get; }
        public virtual Survey Survey { get; }
        public virtual ICollection<Answer> Answers { get; } = new List<Answer>();
    }
}
