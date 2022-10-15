using Microsoft.AspNetCore.Mvc;
using OperatorsClassLibrary;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OperationsController : ControllerBase
    {


        private readonly ILogger<OperationsController> _logger;

        public OperationsController(ILogger<OperationsController> logger)
        {
            _logger = logger;
        }

        /*
         * Below method is used to add two numbers based on the API action
         * @param number1 double, number2 double
         * @return result double 
         */
        [HttpGet]
        public double AddNumbers([FromQuery] double number1, [FromQuery] double number2)
        {
            return Operations.Add(number1, number2);
        }

        /*
         * Below method is used to subtract two numbers based on the API action
         * @param number1 double, number2 double
         * @return result double 
         */
        [HttpGet]
        public double SubtractNumbers([FromQuery] double number1, [FromQuery] double number2)
        {
            return Operations.Subtract(number1, number2);
        }

        /*
         * Below method is used to multiply two numbers based on the API action
         * @param number1 double, number2 double
         * @return result double 
         */
        [HttpGet]
        public double MultiplyNumbers([FromQuery] double number1, [FromQuery] double number2)
        {
            return Operations.Multiply(number1, number2);
        }

        /*
         * Below method is used to divide two numbers based on the API action
         * @param number1 double, number2 double
         * @return result double 
         */
        [HttpGet]
        public double DivideNumbers([FromQuery] double number1, [FromQuery] double number2)
        {
            return Operations.Divide(number1, number2);
        }

    }
}