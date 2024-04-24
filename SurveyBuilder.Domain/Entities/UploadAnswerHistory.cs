using SurveyBuilder.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Domain.Entities
{
    public class UploadAnswerHistory:EntityBase<long>
    {
        public long AccountId { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public string Result { get; set; }
        public virtual Account Account { get;}    
    }
}
