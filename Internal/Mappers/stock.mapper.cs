using StockMarket.Internal.DTo;
using StockDTo = StockMarket.Internal.DTo.Stock;
using Stock = StockMarket.Internal.Models.Stock;

namespace StockMarket.Internal.Mapper
{
    public static class StockMapper
    {
        public static StockDTo ModelToDTO(this Stock StockModel)
        {
            return new StockDTo
            {
                Id = StockModel.Id,
                CompanyName = StockModel.CompanyName,
                Industry = StockModel.Industry,
                Purchase = StockModel.Purchase,
                LastDiv = StockModel.LastDiv,
                Symbol = StockModel.Symbol,
                MarketCap = StockModel.MarketCap,
            };
        }
    }
}