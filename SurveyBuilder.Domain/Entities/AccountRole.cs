using SurveyBuilder.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Domain.Entities
{
    public class AccountRole:EntityBase<long>
    {
        public long AccountId { get; set; }
        public int RoleId { get; set; }
        public virtual Account Account { get; }
        public virtual Role Role { get; }
    }
}
