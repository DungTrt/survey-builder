﻿using SurveyBuilder.Core.Repositories;
using SurveyBuilder.Domain.Entities;
using SurveyBuilder.Infrastructure.Persistence;
using SurveyBuilder.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Infrastructure.Repositories.Implements
{
    public class RoleRepository : RepositoryBaseAsync<Role, int, SurveyBuilderContext>, IRoleRepository
    {
        private readonly SurveyBuilderContext db;
        private readonly IUnitOfWork<SurveyBuilderContext> unitOfWork;
        public RoleRepository(SurveyBuilderContext _dbContext, IUnitOfWork<SurveyBuilderContext> _unitOfWork) : base(_dbContext, _unitOfWork)
        {
            db = _dbContext ?? throw new ArgumentNullException(nameof(_dbContext));
            unitOfWork = _unitOfWork ?? throw new ArgumentNullException(nameof(_unitOfWork));
        }
    }
}
