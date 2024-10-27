using Microsoft.EntityFrameworkCore.Storage.Json;
using Newtonsoft.Json;
using StockMarket.Internal.Data;
using StockMarket.Internal.Interface;
using StockMarket.Internal.Models;
using System.Collections.Generic;

namespace StockMarket.Internal.Service
{
    public class CommentService : IComment
    {
        private readonly ApplicationDBContext _context;
        public CommentService(ApplicationDBContext context)
        {
            _context = context;
        }

        public Comment GetCommentById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetComments()
        {
            throw new NotImplementedException();
        }
    }
}