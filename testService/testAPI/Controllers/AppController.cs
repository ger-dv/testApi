using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using testAPI.Domain.Models;
using testAPI.AppTest;
using testAPI.Domain.Models.InputModels;
using testAPI.Domain.Models.ViewModels;

namespace testAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        
        [Route("GetResult")]
        [HttpGet]
        public IActionResult GetSum([FromQuery][Required] input nums)
        {
            AppTest.AppTest test = new AppTest.AppTest();
            try
            {
                output res = new output();
                res.res = test.GetResult(nums);
                var apiResponse = new ApiResponse<output>();
                apiResponse.Data = res;
                apiResponse.ResponseDate = DateTime.Now;
                return Ok(apiResponse);
            }
            catch (Exception ex) { return Problem(ex.Message); }
        }
    }
}
