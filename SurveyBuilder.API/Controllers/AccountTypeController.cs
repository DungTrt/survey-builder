using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyBuilder.API.Utilities;
using SurveyBuilder.Application.Models;
using SurveyBuilder.Application.Services.Interfaces;
using SurveyBuilder.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace SurveyBuilder.API.Controllers
{
    [Route("api/account-type")]
    [ApiController]
    public class AccountTypeController : BaseController
    {
        private readonly IAccountTypeService service;
        private readonly ILogger<AccountTypeController> logger;
        public AccountTypeController(IAccountTypeService _service, ILoggerFactory loggerFactory)
        {
            service = _service;
            logger = loggerFactory.CreateLogger<AccountTypeController>();
        }

        #region CRUD
        /// <summary>
        /// List account type
        /// </summary>
        /// <returns>Lis account type</returns>
        /// <response code="200">Returns list account type</response>
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
                logger.LogError(ex, $"Failed to get list account type.");
                return BadRequest(ApiResponse.BadRequest(ex.Message));
            }
        }

        /// <summary>
        /// Get account type by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An account type</returns>
        /// <response code="200">Returns an account type</response>
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

                logger.LogError(ex, $"Failed to get account type by id: {id}");
                return BadRequest(ApiResponse.BadRequest(ex.Message));
            }
        }

        /// <summary>
        /// Create an account type
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/account-type/add
        ///     {        
        ///       "name": "this is name",
        ///       "description": "this is description"        
        ///     }
        /// </remarks>
        /// <param name="obj"></param>
        /// <returns>A newly created account type</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response> 
        [HttpPost("add")]
        [ProducesResponseType(typeof(ApiResponse), 201)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        [Produces("application/json")]
        public async Task<IActionResult> Add([FromBody] InsertAccountTypeDTO obj)
        {
            try
            {
                var data = await service.CreateAsync(obj);
                return Ok(data);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to add account type");
                return BadRequest();
            }
        }

        /// <summary>
        /// Update an account type
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /update/account-type/add
        ///     {     
        ///       "id":1  
        ///       "name": "this is name",
        ///       "description": "this is description"        
        ///     }
        /// </remarks>
        /// <param name="obj"></param>
        /// <returns>An updated account type</returns>
        /// <response code="200">Returns the an updated item</response>
        /// <response code="400">If the item is null</response> 
        [HttpPut("update")]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        [Produces("application/json")]
        public async Task<IActionResult> Update([FromBody] UpdateAccountTypeDTO obj)
        {
            try
            {
                var data = await service.UpdateAsync(obj);
                return Ok(data);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to update account type");
                return BadRequest(ApiResponse.BadRequest(ex.Message));
            }
        }

        /// <summary>
        /// Delete an account type
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A updated account type</returns>
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

                logger.LogError(ex, $"Failed to delete account type");
                return BadRequest(ApiResponse.BadRequest(ex.Message));
            }
        }
        #endregion

        #region ADDITION_RESOURCE

        #endregion
    }
}
