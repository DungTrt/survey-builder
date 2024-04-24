using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyBuilder.Application.Services.Interfaces;

namespace SurveyBuilder.API.Controllers
{
    [Route("api/account-survey-answer")]
    [ApiController]
    public class AccountSurveyAnswerController : ControllerBase
    {
        private readonly IAccountSurveyAnswerService service;
        private readonly ILogger<AccountSurveyAnswerController> logger;
        public AccountSurveyAnswerController(IAccountSurveyAnswerService _service, ILoggerFactory loggerFactory)
        {
            service = _service;
            logger = loggerFactory.CreateLogger<AccountSurveyAnswerController>();
        }

        #region CRUD

        #endregion

        #region ADDITION_RESOURCE

        #endregion
    }
}
