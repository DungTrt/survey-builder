using SurveyBuilder.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Core.Entities
{
    public abstract class EntityCommon<TKey> : EntityBase<TKey>, IEntityCommon
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
