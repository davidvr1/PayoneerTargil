using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Targil.Modals;

namespace Targil.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoabWebApi : ControllerBase
    {
        
        private readonly IFactory _factory;
        private readonly ILogger<LoabWebApi> _logger;

        public LoabWebApi(ILogger<LoabWebApi> logger,IFactory factory)
        {
            _logger = logger;
            _factory = factory;
        }

        [HttpPost(Name = "GetLoan")]
        public  IActionResult GetLoan([FromBody] LoanRequest loanRequest)
        {

            decimal total=_factory.SetClientIdForProposal(loanRequest.ID).CalculateLoan(loanRequest.Amount,loanRequest.Period);
            return Ok(total);
        }
    }
}
