using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyBuilder.Application.Services.Interfaces;

namespace SurveyBuilder.API.Controllers
{
    [Route("api/account-role")]
    [ApiController]
    public class AccountRoleController : ControllerBase
    {
        private readonly IAccountRoleService service;
        private readonly ILogger<AccountRoleController> logger;
        public AccountRoleController(IAccountRoleService _service, ILoggerFactory loggerFactory)
        {
            service = _service;
            logger = loggerFactory.CreateLogger<AccountRoleController>();
        }

        #region CRUD

        #endregion

        #region ADDITION_RESOURCE

        #endregion
    }
}
