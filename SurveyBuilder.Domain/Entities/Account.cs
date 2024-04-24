using SurveyBuilder.Core.Entities;
using SurveyBuilder.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Domain.Entities
{
    public class Account : EntityBase<long>, IFullTextSearch
    {
        public string Search { get; set; }
        public int AccountTypeId { get; set; }
        public int AccountStatusId { get; set; }
        public int? AccountCategoryId { get; set; }
        public string? BusinessName { get; set; }
        public string Name { get; set; }
        public string? FirstName { get; set; }
        public string? Function { get; set; }
        public string? Service { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Such { get; set; }
        public string? CompanyCustomerCode { get; set; }
        public string? AuthorizeEmailContact { get; set; }
        public string? IndividualCustomer { get; set; }
        public string? AuthorizeContactTel { get; set; }
        public int AccessFailedCount { get; set; }
        public bool LockEnabled { get; set; }
        public DateTime? LockEndDate { get; set; }
        public virtual AccountCategory? AccountCategory { get; }
        public virtual AccountStatus AccountStatus { get; }
        public virtual AccountType AccountType { get; }
        public virtual ICollection<AccountRole> AccountRoles { get; } = new List<AccountRole>();
        public virtual ICollection<AccountSurvey> AccountSurveys { get; } = new List<AccountSurvey>();
        public virtual ICollection<Survey> Surveys { get; } = new List<Survey>();
        public virtual ICollection<UploadAnswerHistory> UploadAnswerHistories { get; } = new List<UploadAnswerHistory>();
        public virtual ICollection<UploadBillHistory> UploadBillHistories { get; } = new List<UploadBillHistory>();

    }
}
