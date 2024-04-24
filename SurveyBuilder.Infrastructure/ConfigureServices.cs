using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SurveyBuilder.Core.Repositories;
using SurveyBuilder.Infrastructure.Persistence;
using SurveyBuilder.Infrastructure.Repositories.Implements;
using SurveyBuilder.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SurveyBuilderContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"),
                builder => builder.MigrationsAssembly(typeof(SurveyBuilderContext).Assembly.FullName)));
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>))
                .AddScoped(typeof(IRepositoryBaseAsync<,,>), typeof(RepositoryBaseAsync<,,>))
                .AddScoped<IAccountCategoryRepository, AccountCategoryRepository>()
                .AddScoped<IAccountRepository, AccountRepository>()
                .AddScoped<IAccountRoleRepository, AccountRoleRepository>()
                .AddScoped<IAccountStatusRepository, AccountStatusRepository>()
                .AddScoped<IAccountSurveyRepository, AccountSurveyRepository>()
                .AddScoped<IAccountSurveyAnswerRepository, AccountSurveyAnswerRepository>()
                .AddScoped<IAccountTypeRepository, AccountTypeRepository>()
                .AddScoped<IAnswerRepository, AnswerRepository>()
                .AddScoped<IBillRepository, BillRepository>()
                .AddScoped<IOrderRepository, OrderRepository>()
                .AddScoped<IOrderStatusRepository, OrderStatusRepository>()
                .AddScoped<IPermissionRepository, PermissionRepository>()
                .AddScoped<IQuestionRepository, QuestionRepository>()
                .AddScoped<IQuestionTypeRepository, QuestionTypeRepository>()
                .AddScoped<IRoleRepository, RoleRepository>()
                .AddScoped<IRolePermissionRepository, RolePermissionRepository>()
                .AddScoped<ISurveyRepository, SurveyRepository>()
                .AddScoped<IRolePermissionRepository, RolePermissionRepository>()
                .AddScoped<ISystemConfigRepository, SystemConfigRepository>()
                .AddScoped<IUploadAnswerHistoryRepository, UploadAnswerHistoryRepository>()
                .AddScoped<IUploadBillHistoryRepository, UploadBillHistoryRepository>();

            return services;
        }
    }
}
