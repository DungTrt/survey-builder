using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyBuilder.Application.Services.Interfaces;

namespace SurveyBuilder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService service;
        private readonly ILogger<PermissionController> logger;  
        public PermissionController(IPermissionService _service,ILoggerFactory loggerFactory)
        {
            service = _service;
            logger = loggerFactory.CreateLogger<PermissionController>();
        }

        #region CRUD

        #endregion

        #region ADDITION_RESOURCE

        #endregion
    }
}
