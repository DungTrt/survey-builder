using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SurveyBuilder.Core.Entities;

namespace SurveyBuilder.API.Utilities
{
    public class BaseController : Controller
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext filterContext, ActionExecutionDelegate next)
        {
            if (!ModelState.IsValid)//valid model state
            {
                var errors = ModelState.Values.SelectMany(c => c.Errors).Select(c => c.ErrorMessage);
                filterContext.Result = Ok(ApiResponse.BadRequest(errors));
            }

            await base.OnActionExecutionAsync(filterContext, next);


        }
    }
}
