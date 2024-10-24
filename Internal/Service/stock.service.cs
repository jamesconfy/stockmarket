using Microsoft.EntityFrameworkCore.Storage.Json;
using Newtonsoft.Json;
using StockMarket.Internal.Data;
using StockMarket.Internal.Interface;
using StockMarket.Internal.Models;
using System.Collections.Generic;

namespace StockMarket.Internal.Service
{
    public class StockService : IStock
    {
        private readonly ApplicationDBContext _context;
        public StockService(ApplicationDBContext context) 
        { 
            _context = context;
        }

        public List<Stock>? GetAllStocks()
        {
            List<Stock>? stocks = null;
            stocks = _context.Stocks.ToList();

            //var errIndicatior = 0;
            //try 
            //{
            //    stocks = _context.Stocks.ToList();
            //    errIndicatior = 1;
            //} catch(Exception ex) 
            //{
            //    errIndicatior = 0;
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine($"message: {ex.Message}, stacktrace: {ex.StackTrace}");
            //    Console.WriteLine($"{JsonConvert.SerializeObject(ex)}");  
            //}

            return stocks;
        }

        public Stock? GetStockById(int id)
        {
            var stock = _context.Stocks.Find(id);

            return stock;
        }
    }
}

