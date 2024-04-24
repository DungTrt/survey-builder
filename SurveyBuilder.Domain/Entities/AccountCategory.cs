using SurveyBuilder.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Domain.Entities
{
    public class AccountCategory : EntityCommon<int>
    {
        public string Color { get; set; }
        public virtual ICollection<Account> Accounts { get; } = new List<Account>();
    }
}
