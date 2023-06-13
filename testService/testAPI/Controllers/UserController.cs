using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using testAPI.Domain.Interfaces;
using testAPI.Domain.Models;
using testAPI.Domain.Models.ViewModels;

namespace testAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository repository)
        {
            _userRepository = repository;
        }

        [Route("GetUserData")]
        [HttpGet]
        public async Task<IActionResult> GetUsersData([FromQuery][Required] int resultsQty)
        {
            try
            {
                ApiResponse<userViewModel> apiResponse = new ApiResponse<userViewModel>();
                userViewModel resp = await _userRepository.GetUsersData(resultsQty);
                apiResponse.Data = resp;
                apiResponse.ResponseDate = DateTime.Now;
                return Ok(apiResponse);
            }
            catch (Exception ex) { return Problem(ex.Message); }
        }
    }
}
