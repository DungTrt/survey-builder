using SurveyBuilder.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Domain.Entities
{
    public class RolePermission : EntityBase<long>
    {
        public int PermissionId { get; set; }
        public int RoleId { get; set; }
        public virtual Permission Permission { get; }
        public virtual Role Role { get; }
    }
}
