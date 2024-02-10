

using Day4_BookProject.Consts;

namespace Day4_BookProject.Exceptions
{
    public class BookTitleException : Exception
    {
        public BookTitleException(string title): base(Messages.BookTitleExceptionMessage(title))
        {
            
        }
    }
}
