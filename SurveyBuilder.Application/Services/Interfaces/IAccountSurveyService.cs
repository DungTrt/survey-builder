using SurveyBuilder.Application.Models;
using SurveyBuilder.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Application.Services.Interfaces
{
    public interface IAccountSurveyService : IServiceQueryBase<long, InsertAccountSurveyDTO, UpdateAccountSurveyDTO, AccountSurveyDTO>
    {
    }
}
