using FluentValidation;
using SurveyBuilder.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Application.Validators.AccountStatus
{
    internal class UpdateAccountStatusDTOValidation : AbstractValidator<UpdateAccountStatusDTO>
    {
        public UpdateAccountStatusDTOValidation()
        {
            RuleFor(x => x.Id).NotNull().WithMessage("Id is required.")
                .GreaterThan(0)
                .WithMessage("Id must be greater than 0.");
            RuleFor(x => x.Name).NotEmpty()
                            .WithMessage("Please enter account status name.")
                            .MaximumLength(255)
                            .WithMessage("The name field can have no more 255 characters.");
            RuleFor(x => x.Name).Matches(@"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂẾưăạảấầẩẫậắằẳẵặẹẻẽềềểếỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹý\-\s]+$")
                            .WithMessage("The name field does not include digit and special characters");
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("The description field can have no more 500 characters.");
            RuleFor(x => x.Color).NotEmpty()
                           .WithMessage("Please enter color.")
                           .MaximumLength(20)
                           .WithMessage("The color field can have no more 20 characters.");
        }
    }
}
