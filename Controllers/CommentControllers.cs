using Microsoft.AspNetCore.Mvc;
using StockMarket.Internal.Data;

namespace StockMarket.Controllers
{
    [Route("/api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        public StockController(ApplicationDBContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var stocks = _dbContext.Stocks.ToList();

            return Ok(stocks);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id) 
        {
            var stock = _dbContext.Stocks.Find(id);

            if (stock == null) { 
                return NotFound(stock);
            }

            return Ok(stock);
        }
  
    }
}
