using StockMarket.Internal.Models;

namespace StockMarket.Internal.Interface { 
    public interface IComment {
       public List<Comment> GetComments();
       public Comment GetCommentById(int id);

    }
}