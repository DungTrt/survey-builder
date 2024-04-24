using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Core.Entities.Interfaces
{
    public interface IAuditable: IDateTracking,IUserTracking
    {
    }
}
