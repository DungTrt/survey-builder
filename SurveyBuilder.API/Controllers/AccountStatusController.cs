using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyBuilder.Application.Models;
using SurveyBuilder.Application.Services.Interfaces;
using SurveyBuilder.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace SurveyBuilder.API.Controllers
{
    [Route("api/account-status")]
    [ApiController]
    public class AccountStatusController : ControllerBase
    {
        private readonly IAccountStatusService service;
        private readonly ILogger<AccountStatusController> logger;
        public AccountStatusController(IAccountStatusService _service, ILoggerFactory loggerFactory)
        {
            service = _service;
            logger =loggerFactory.CreateLogger<AccountStatusController>();
        }

        #region CRUD
        /// <summary>
        /// List account status
        /// </summary>
        /// <returns>Lis account type</returns>
        /// <response code="200">Returns list account status</response>
        /// <response code="400">If error occur</response> 
        [HttpGet("list")]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        [Produces("application/json")]
        public async Task<IActionResult> GetListAsync()
        {
            try
            {
                var data = await service.GetAllAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to get list account status.");
                return BadRequest(ApiResponse.BadRequest(ex.Message));
            }
        }

        /// <summary>
        /// Get account status by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An account type</returns>
        /// <response code="200">Returns an account status</response>
        /// <response code="400">If error occur</response> 
        [HttpGet("detail/{id}")]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        [Produces("application/json")]
        public async Task<IActionResult> Detail([Required] int id)
        {
            try
            {
                var data = await service.GetByIdAsync(id);
                return Ok(data);

            }
            catch (Exception ex)
            {

                logger.LogError(ex, $"Failed to get account status by id: {id}");
                return BadRequest(ApiResponse.BadRequest(ex.Message));
            }
        }

        /// <summary>
        /// Create an account status
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/account-status/add
        ///     {        
        ///       "name": "this is name",
        ///       "color":"#000"
        ///       "description": "this is description"        
        ///     }
        /// </remarks>
        /// <param name="obj"></param>
        /// <returns>A newly created account status</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response> 
        [HttpPost("add")]
        [ProducesResponseType(typeof(ApiResponse), 201)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        [Produces("application/json")]
        public async Task<IActionResult> Add([FromBody] InsertAccountStatusDTO obj)
        {
            try
            {
                var data = await service.CreateAsync(obj);
                return Ok(data);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to add account status");
                return BadRequest(ApiResponse.BadRequest(ex.Message));
            }
        }

        /// <summary>
        /// Update an account status
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /update/account-status/update
        ///     {     
        ///       "id":1  
        ///       "name": "this is name",
        ///       "description": "this is description" ,
        ///       "color:"#ccc"
        ///     }
        /// </remarks>
        /// <param name="obj"></param>
        /// <returns>An updated account status</returns>
        /// <response code="200">Returns the an updated item</response>
        /// <response code="400">If the item is null</response> 
        [HttpPut("update")]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        [Produces("application/json")]
        public async Task<IActionResult> Update([FromBody] UpdateAccountStatusDTO obj)
        {
            try
            {
                var data = await service.UpdateAsync(obj);
                return Ok(data);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to update account status");
                return BadRequest(ApiResponse.BadRequest(ex.Message));
            }
        }

        /// <summary>
        /// Delete an account status
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("delete/{id}")]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        [Produces("application/json")]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                var data = await service.SoftDeleteAsync(id);
                return Ok(data);
            }
            catch (Exception ex)
            {

                logger.LogError(ex, $"Failed to delete account status");
                return BadRequest(ApiResponse.BadRequest(ex.Message));
            }
        }
        #endregion

        #region ADDITION_RESOURCE

        #endregion
    }
}
