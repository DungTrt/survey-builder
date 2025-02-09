﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Application.Models
{
    public class InsertAccountStatusDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Color { get; set; }
        public string? Description { get; set; }
    }
}
