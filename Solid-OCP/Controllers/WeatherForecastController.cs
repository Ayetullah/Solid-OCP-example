using Microsoft.AspNetCore.Mvc;
using Solid_OCP.Helpers;
using Solid_OCP.Models;
using System.Collections.Generic;
using System.Linq;

namespace Solid_OCP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
      
        [HttpGet]
        public IActionResult Get()
        {
            var str = "Deneme";
            List<ValidationModel> validations = new List<ValidationModel>(){
                new ValidationModel() { ValidationType = ValidationType.UpperCase, Value = true },
                new ValidationModel() { ValidationType = ValidationType.Digit, Value = true },
            };
            var isValid = true;
            foreach (var item in validations.Where(x => x.Value == true))
            {
                isValid = isValid && str.IsValidPassword(item);
            }

            return Ok(isValid);
        }
    }
}
