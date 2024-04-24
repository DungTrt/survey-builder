using FluentValidation;
using SurveyBuilder.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Application.Validators.AccountType
{
    public class UpdateAccountTypeDTOValidation:AbstractValidator<UpdateAccountTypeDTO>
    {
        public UpdateAccountTypeDTOValidation()
        {
            RuleFor(x => x.Id).NotNull().WithMessage("Id is required.")
                .GreaterThan(0).WithMessage("Id must be greater than 0.");
            RuleFor(x => x.Name).NotEmpty()
                            .WithMessage("Please enter account type name.")
                            .MaximumLength(255)
                            .WithMessage("The name field can have no more 255 characters.");
            RuleFor(x=>x.Name).Matches(@"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂẾưăạảấầẩẫậắằẳẵặẹẻẽềềểếỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹý\-\s]+$")
                            .WithMessage("The name field does not include digit and special characters");
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("The description field can have no more 500 characters.");
        }
    }
}
