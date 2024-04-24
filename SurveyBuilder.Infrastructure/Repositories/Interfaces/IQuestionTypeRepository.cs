using SurveyBuilder.Core.Repositories;
using SurveyBuilder.Domain.Entities;
using SurveyBuilder.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Infrastructure.Repositories.Interfaces
{
    public interface IQuestionTypeRepository : IRepositoryBaseAsync<QuestionType, int, SurveyBuilderContext>
    {
    }
}
