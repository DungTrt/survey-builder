using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyBuilder.Application.Services.Interfaces;

namespace SurveyBuilder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService service;
        private readonly ILogger<OrdersController> logger;  
        public OrdersController(IOrderService _service,ILoggerFactory loggerFactory)
        {
            service = _service;
            logger = loggerFactory.CreateLogger<OrdersController>();
        }

        #region CRUD

        #endregion

        #region ADDITION_RESOURCE

        #endregion
    }
}
