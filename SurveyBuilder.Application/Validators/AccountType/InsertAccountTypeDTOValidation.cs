using FluentValidation;
using SurveyBuilder.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Application.Validators.AccountType
{
    public class InsertAccountTypeDTOValidation:AbstractValidator<InsertAccountTypeDTO>
    {
        public InsertAccountTypeDTOValidation()
        {
            RuleFor(x => x.Name).NotEmpty()
                .WithMessage("Please enter account type name.")
                .MaximumLength(255).WithMessage("The name field can have no more 255 characters.");
            RuleFor(x => x.Name).Must(NotIncludeDigitAndSpecialCharater).WithMessage("The name field does not include digit and special characters.");
            //RuleFor(x => x.Name).Matches(@"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂẾưăạảấầẩẫậắằẳẵặẹẻẽềềểếỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹý\-\s]+$")
            //    .WithMessage("The name field does not include digit and special characters");
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("The description field can have no more 500 characters.");
        }
        private bool NotIncludeDigitAndSpecialCharater(string text)
        {
            var listIgnoreCharacters=new List<string>() { "!","@","#","$","%","^","&","*",";","0","1","2","3","4","5","6","7","8","9"};
            foreach (var character in listIgnoreCharacters)
            {
                if (text.Contains(character))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
