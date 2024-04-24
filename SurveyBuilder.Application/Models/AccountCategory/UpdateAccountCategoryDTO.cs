using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Application.Models
{
    public class UpdateAccountCategoryDTO : InsertAccountCategoryDTO
    {
        [Required]
        public int Id { get; set; }
    }
}
