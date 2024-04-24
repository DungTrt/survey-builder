using SurveyBuilder.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Core.Entities
{
    public class EntityAuditBase<T> : EntityBase<T>, IAuditable
    {
        public DateTime LastModifiedTime { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
