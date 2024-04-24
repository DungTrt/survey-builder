using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyBuilder.Application.Models;
using SurveyBuilder.Application.Services.Interfaces;
using SurveyBuilder.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace SurveyBuilder.API.Controllers
{
    [Route("api/account-category")]
    [ApiController]
    public class AccountCategoryController : ControllerBase
    {
        private readonly IAccountCategoryService service;
        private readonly ILogger<AccountCategoryController> logger;
        public AccountCategoryController(IAccountCategoryService _service, ILoggerFactory loggerFactory)
        {
            service = _service;
            logger = loggerFactory.CreateLogger<AccountCategoryController>();

        }

        #region CRUD
        /// <summary>
        /// List account category
        /// </summary>
        /// <returns>Lis account category</returns>
        /// <response code="200">Returns list account category</response>
        /// <response code="400">If error occur</response> 
        [HttpGet("list")]
        [ProducesResponseType(typeof(ApiResponse),200)]
        [ProducesResponseType(typeof(ApiResponse),400)]
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
                logger.LogError(ex, $"Failed to get list account category.");
                return BadRequest(ApiResponse.BadRequest(ex.Message));
            }
        }

        /// <summary>
        /// Get account category by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An account category</returns>
        /// <response code="200">Returns an account category</response>
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

                logger.LogError(ex, $"Failed to get account category by id: {id}");
                return BadRequest(ApiResponse.BadRequest(ex.Message));
            }
        }

        /// <summary>
        /// Create an account category
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/account-category/add
        ///     {        
        ///       "name": "this is name",
        ///       "color":"#000"
        ///       "description": "this is description"        
        ///     }
        /// </remarks>
        /// <param name="obj"></param>
        /// <returns>A newly created account category</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response> 
        [HttpPost("add")]
        [ProducesResponseType(typeof(ApiResponse), 201)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        [Produces("application/json")]
        public async Task<IActionResult> Add([FromBody] InsertAccountCategoryDTO obj)
        {
            try
            {
                var data = await service.CreateAsync(obj);
                return Ok(data);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to add account category");
                return BadRequest(ApiResponse.BadRequest(ex.Message));
            }
        }

        /// <summary>
        /// Update an account category
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /update/account-category/update
        ///     {     
        ///       "id":1  
        ///       "name": "this is name",
        ///       "description": "this is description" ,
        ///       "color:"#ccc"
        ///     }
        /// </remarks>
        /// <param name="obj"></param>
        /// <returns>An updated account category</returns>
        /// <response code="200">Returns the an updated item</response>
        /// <response code="400">If the item is null</response> 
        [HttpPut("update")]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        [Produces("application/json")]
        public async Task<IActionResult> Update([FromBody] UpdateAccountCategoryDTO obj)
        {
            try
            {
                var data = await service.UpdateAsync(obj);
                return Ok(data);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to update account category");
                return BadRequest(ApiResponse.BadRequest(ex.Message));
            }
        }

        /// <summary>
        /// Delete an account category
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

                logger.LogError(ex, $"Failed to delete account category");
                return BadRequest(ApiResponse.BadRequest(ex.Message));
            }
        }
        #endregion

        #region ADDITION_RESOURCE

        #endregion
    }
}
