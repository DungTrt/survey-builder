using FluentValidation.AspNetCore;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SurveyBuilder.Application.Services.Interfaces;
using SurveyBuilder.Application.Services.Implements;

namespace SurveyBuilder.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddFluentValidationAutoValidation(options => options.DisableDataAnnotationsValidation = true);
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMemoryCache();
            services.AddHttpContextAccessor();

            services.AddScoped<IAccountCategoryService, AccountCategoryService>()
                .AddScoped<IAccountService, AccountService>()
                .AddScoped<IAccountRoleService, AccountRoleService>()
                .AddScoped<IAccountStatusService, AccountStatusService>()
                .AddScoped<IAccountSurveyService, AccountSurveyService>()
                .AddScoped<IAccountSurveyAnswerService, AccountSurveyAnswerService>()
                .AddScoped<IAccountTypeService, AccountTypeService>()
                .AddScoped<IAnswerService, AnswerService>()
                .AddScoped<IBillService, BillService>()
                .AddScoped<IOrderService, OrderService>()
                .AddScoped<IOrderStatusService, OrderStatusService>()
                .AddScoped<IPermissionService, PermissionService>()
                .AddScoped<IQuestionService, QuestionService>()
                .AddScoped<IQuestionTypeService, QuestionTypeService>()
                .AddScoped<IRoleService, RoleService>()
                .AddScoped<IRolePermissionService, RolePermissionService>()
                .AddScoped<ISurveyService, SurveyService>()
                .AddScoped<IRolePermissionService, RolePermissionService>()
                .AddScoped<ISystemConfigService, SystemConfigService>()
                .AddScoped<IUploadAnswerHistoryService, UploadAnswerHistoryService>()
                .AddScoped<IUploadBillHistoryService, UploadBillHistoryService>()
                .AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
