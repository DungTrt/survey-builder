using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyBuilder.Application.Services.Interfaces;

namespace SurveyBuilder.API.Controllers
{
    [Route("api/upload-answer-history")]
    [ApiController]
    public class UploadAnswerHistoryController : ControllerBase
    {
        private readonly IUploadAnswerHistoryService service;
        private readonly ILogger<UploadAnswerHistoryController> logger;
        public UploadAnswerHistoryController(IUploadAnswerHistoryService _service, ILoggerFactory loggerFactory)
        {
            service = _service;
            logger = loggerFactory.CreateLogger<UploadAnswerHistoryController>();
        }

        #region CRUD

        #endregion

        #region ADDITION_RESOURCE

        #endregion
    }
}
