using StockMarket.Internal.Models;

namespace StockMarket.Internal.Interface
{
	public interface IStock
	{
		public List<Stock>? GetAllStocks();
		public Stock? GetStockById(int id);
	}
}