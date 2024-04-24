using SurveyBuilder.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Domain.Entities
{
    public class Orders: EntityFullTextSearch<long>
    {
        public int OrderStatusId { get; set; }
        public long AccountSurveyId { get; set; }
        public decimal Amount { get; set; }
        public string? TransactionCode { get; set; }
        public string? Info { get; set; }
        public DateTime? PaymentDate { get; set; }
        public virtual OrderStatus OrderStatus { get; }
        public virtual AccountSurvey AccountSurvey { get; }
        public virtual Bills Bills { get; }
    }
}
