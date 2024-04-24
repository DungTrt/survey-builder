using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyBuilder.Application.Services.Interfaces;

namespace SurveyBuilder.API.Controllers
{
    [Route("api/upload-bill-history")]
    [ApiController]
    public class UploadBillHistoryController : ControllerBase
    {
        private readonly IUploadBillHistoryService service;
        private readonly ILogger<UploadBillHistoryController> logger;
        public UploadBillHistoryController(IUploadBillHistoryService _service, ILoggerFactory loggerFactory)
        {
            service = _service;
            logger = loggerFactory.CreateLogger<UploadBillHistoryController>();
        }

        #region CRUD

        #endregion

        #region ADDITION_RESOURCE

        #endregion
    }
}
