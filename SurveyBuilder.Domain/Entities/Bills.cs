using SurveyBuilder.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Domain.Entities
{
    public class Bills:EntityBase<long>
    {
        public long OrderId { get; set; }
        public string Path { get; set; }
        public virtual Orders Orders { get; }
    }
}
