using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket.Internal.Models
{
    public class Stock
    {
        public int Id { get; set; } = 0;

        public string CompanyName { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; } = 0;
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
