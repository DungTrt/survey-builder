using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyBuilder.Application.Services.Interfaces;

namespace SurveyBuilder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService service;
        private readonly ILogger<QuestionController> logger;
        public QuestionController(IQuestionService _service,ILoggerFactory loggerFactory)
        {
            service = _service;
            logger = loggerFactory.CreateLogger<QuestionController>();
        }

        #region CRUD

        #endregion

        #region ADDITION_RESOURCE

        #endregion
    }
}
