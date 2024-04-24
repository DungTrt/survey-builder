using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyBuilder.Application.Services.Interfaces;

namespace SurveyBuilder.API.Controllers
{
    [Route("api/account-survey")]
    [ApiController]
    public class AccountSurveyController : ControllerBase
    {
        private readonly IAccountSurveyService service;
        private readonly ILogger<AccountSurveyController> logger;
        public AccountSurveyController(IAccountSurveyService _service,ILoggerFactory loggerFactory)
        {
            service = _service;
            logger= loggerFactory.CreateLogger<AccountSurveyController>();
        }

        #region CRUD

        #endregion

        #region ADDITION_RESOURCE

        #endregion
    }
}
