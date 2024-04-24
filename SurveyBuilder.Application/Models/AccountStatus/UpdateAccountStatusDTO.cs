using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Application.Models
{
    public class UpdateAccountStatusDTO : InsertAccountStatusDTO
    {
        [Required]
        public int Id { get; set; }
    }
}
