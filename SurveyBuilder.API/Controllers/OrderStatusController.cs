using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyBuilder.Application.Services.Interfaces;

namespace SurveyBuilder.API.Controllers
{
    [Route("api/order-status")]
    [ApiController]
    public class OrderStatusController : ControllerBase
    {
        private readonly IOrderStatusService service;
        private readonly ILogger<OrderStatusController> logger;
        public OrderStatusController(IOrderStatusService _service,ILoggerFactory loggerFactory)
        {
            service = _service;
            logger =loggerFactory.CreateLogger<OrderStatusController>();
        }

        #region CRUD

        #endregion

        #region ADDITION_RESOURCE

        #endregion
    }
}
