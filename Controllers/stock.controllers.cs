using Microsoft.AspNetCore.Mvc;
using StockMarket.Internal.Data;
using StockMarket.Internal.Models;
using StockMarket.Internal.Service;

namespace StockMarket.Controllers
{
    [Route("/api/stocks")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly StockService _stockService;
        public StockController(StockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var stocks = _stockService.GetAllStocks();

            return Ok(stocks);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var stock = _stockService.GetStockById(id);

            if (stock == null)
            {
                return NotFound(stock);
            }

            return Ok(stock);
        }

    }
}
