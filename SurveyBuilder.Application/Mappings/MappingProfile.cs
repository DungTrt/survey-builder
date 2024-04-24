using AutoMapper;
using SurveyBuilder.Application.Models;
using SurveyBuilder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Account
            CreateMap<InsertAccountDTO, Account>();
            CreateMap<UpdateAccountDTO, Account>().IgnoreAllNonExisting();
            CreateMap<Account, AccountDTO>().ReverseMap();
            #endregion

            #region Account Category
            CreateMap<InsertAccountCategoryDTO, AccountCategory>();
            CreateMap<UpdateAccountCategoryDTO, AccountCategory>().IgnoreAllNonExisting();
            CreateMap<AccountCategory, AccountCategoryDTO>().ReverseMap();
            #endregion

            #region Account Role
            CreateMap<InsertAccountRoleDTO, AccountRole>();
            CreateMap<UpdateAccountRoleDTO, AccountRole>().IgnoreAllNonExisting();
            CreateMap<AccountRole, AccountRoleDTO>().ReverseMap();
            #endregion

            #region Account Status
            CreateMap<InsertAccountStatusDTO, AccountStatus>();
            CreateMap<UpdateAccountStatusDTO, AccountStatus>().IgnoreAllNonExisting();
            CreateMap<AccountStatus, AccountStatusDTO>().ReverseMap();
            #endregion

            #region Account Survey
            CreateMap<InsertAccountSurveyDTO, AccountSurvey>();
            CreateMap<UpdateAccountSurveyDTO, AccountSurvey>().IgnoreAllNonExisting();
            CreateMap<AccountSurvey, AccountSurveyDTO>().ReverseMap();
            #endregion

            #region Account Survey Answer
            CreateMap<InsertAccountSurveyAnswerDTO, AccountSurveyAnswer>();
            CreateMap<UpdateAccountSurveyAnswerDTO, AccountSurveyAnswer>().IgnoreAllNonExisting();
            CreateMap<AccountSurveyAnswer, AccountSurveyAnswerDTO>().ReverseMap();
            #endregion

            #region Account Type
            CreateMap<InsertAccountTypeDTO, AccountType>();
            CreateMap<UpdateAccountTypeDTO, AccountType>().IgnoreAllNonExisting();
            CreateMap<AccountType, AccountTypeDTO>().ReverseMap();
            #endregion

            #region Answer
            CreateMap<InsertAnswerDTO, Answer>();
            CreateMap<UpdateAnswerDTO, Answer>().IgnoreAllNonExisting();
            CreateMap<Answer, AnswerDTO>().ReverseMap();
            #endregion

            #region Bills
            CreateMap<InsertBillDTO, Bills>();
            CreateMap<UpdateBillDTO, Bills>().IgnoreAllNonExisting();
            CreateMap<Bills, BillDTO>().ReverseMap();
            #endregion

            #region Orders
            CreateMap<InsertOrderDTO, Orders>();
            CreateMap<UpdateOrderDTO, Orders>().IgnoreAllNonExisting();
            CreateMap<Orders, OrderDTO>().ReverseMap();
            #endregion

            #region OrderStatus
            CreateMap<InsertOrderStatusDTO, OrderStatus>();
            CreateMap<UpdateOrderStatusDTO, OrderStatus>().IgnoreAllNonExisting();
            CreateMap<OrderStatus, OrderStatusDTO>().ReverseMap();
            #endregion

            #region Permission
            CreateMap<InsertPermissionDTO, Permission>();
            CreateMap<UpdatePermissionDTO, Permission>().IgnoreAllNonExisting();
            CreateMap<Permission, PermissionDTO>().ReverseMap();
            #endregion

            #region Question
            CreateMap<InsertQuestionDTO, Question>();
            CreateMap<UpdateQuestionDTO, Question>().IgnoreAllNonExisting();
            CreateMap<Question, QuestionDTO>().ReverseMap();
            #endregion

            #region Question Type
            CreateMap<InsertQuestionTypeDTO, QuestionType>();
            CreateMap<UpdateQuestionTypeDTO, QuestionType>().IgnoreAllNonExisting();
            CreateMap<QuestionType, QuestionTypeDTO>().ReverseMap();
            #endregion

            #region Role
            CreateMap<InsertRoleDTO, Role>();
            CreateMap<UpdateRoleDTO, Role>().IgnoreAllNonExisting();
            CreateMap<Role, RoleDTO>().ReverseMap();
            #endregion

            #region Role Permission
            CreateMap<InsertRolePermissionDTO, RolePermission>();
            CreateMap<UpdateRolePermissionDTO, RolePermission>().IgnoreAllNonExisting();
            CreateMap<RolePermission, RolePermissionDTO>().ReverseMap();
            #endregion

            #region Survey
            CreateMap<InsertSurveyDTO, Survey>();
            CreateMap<UpdateSurveyDTO, Survey>().IgnoreAllNonExisting();
            CreateMap<Survey, SurveyDTO>().ReverseMap();
            #endregion            
            
            #region SystemConfig
            CreateMap<InsertSystemConfigDTO, SystemConfig>();
            CreateMap<UpdateSystemConfigDTO, SystemConfig>().IgnoreAllNonExisting();
            CreateMap<SystemConfig, SystemConfigDTO>().ReverseMap();
            #endregion
            
            #region Upload Answer History
            CreateMap<InsertUploadAnswerHistoryDTO, UploadAnswerHistory>();
            CreateMap<UpdateUploadAnswerHistoryDTO, UploadAnswerHistory>().IgnoreAllNonExisting();
            CreateMap<UploadAnswerHistory, UploadAnswerHistoryDTO>().ReverseMap();
            #endregion            
            
            #region Upload Bill History
            CreateMap<InsertUploadBillHistoryDTO, UploadBillHistory>();
            CreateMap<UpdateUploadBillHistoryDTO, UploadBillHistory>().IgnoreAllNonExisting();
            CreateMap<UploadBillHistory, UploadBillHistoryDTO>().ReverseMap();
            #endregion
        }
    }
}
