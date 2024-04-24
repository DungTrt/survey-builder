using SurveyBuilder.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Domain.Entities
{
    public class SystemConfig:EntityBase<int>
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string? Description { get; set; }
    }
}
