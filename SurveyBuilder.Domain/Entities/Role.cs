using SurveyBuilder.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Domain.Entities
{
    public class Role:EntityCommon<int>
    {
        public virtual ICollection<AccountRole> AccountRoles { get; }  =new List<AccountRole>();   
        public virtual ICollection<RolePermission> RolePermissions { get; } = new List<RolePermission>();
    }
}
