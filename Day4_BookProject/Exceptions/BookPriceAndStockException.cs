using Day4_BookProject.Consts;
using System.Drawing;

namespace Day4_BookProject.Exceptions;

public class BookPriceAndStockException : Exception
{
    public BookPriceAndStockException(double price, int stock) : base(Messages.BookPriceAndStockExceptionMessage(price,stock))
    {
        
    }
}
