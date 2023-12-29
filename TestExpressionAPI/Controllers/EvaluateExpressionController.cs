using Microsoft.AspNetCore.Mvc;
using TestExpression.StringEvaluator;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestExpression.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvaluateExpressionController : ControllerBase
    {


        // Get api/<EvaluateExpressionController>
        [HttpGet]
        public string Get(string value)
        {
            Evaluator stringEvaluator = new Evaluator();


            return stringEvaluator.Evaluate(value).ToString();

        }


    }
}
