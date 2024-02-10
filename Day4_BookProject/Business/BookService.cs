
using Day4_BookProject.Data;
using Day4_BookProject.Exceptions;
using Day4_BookProject.Models;

namespace Day4_BookProject.Business;


// Dependency Injection (Çeşitleri = Constructor args Injection, Setter Injection, Method Injection)
// AddScopped, AddSingleton, AddTransient

// SOLID Yazılım geliştirme prensipleri
// Single Responsibility (=her oluşturulan class sadece bir işi görmeli)
// Open Closed (Değişime kapalı, gelişime açık metotlar)
// Liskov subs.
// Interface segre.
// Dependency Inversion
public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }


    // Ekleme işi yaparken kitap başlığı minimum 2 karakterli olmalıdır.
    // Price ve Stock property'leri negatif değer alamaz.
    public void Add(Book book)
    {
        // Validasyon kurallarından geçmeyen kitabı listeye eklemeyeceğiz
        try
        {
            AddRules(book);
            _bookRepository.Add(book);
            GetList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        // catch blokları 1. yöntem
        //catch (BookTitleException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //catch (BookPriceAndStockException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}


    }

    public void Delete(int id)
    {
        try
        {
            _bookRepository.Delete(id);
            GetList();
        }
        catch (BookNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    public void GetById(int id)
    {

        try
        {
            Book? book = _bookRepository.GetById(id);
            Console.WriteLine(book);
        }
        catch (BookNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetList()
    {
        List<Book> books = _bookRepository.GetAll();
        books.ForEach(book => Console.WriteLine(book));
    }

    // BookService_bookTitleLengthLetterThanTwo_ThrowsException() unittest'te genelde adlandırma bu şekilde oluyor
    private void AddRules(Book book)
    {
        if (book.Title.Length < 2)
        {
            throw new BookTitleException(book.Title);
        }

        if (book.Price < 0 || book.Stock < 0)
        {
            throw new BookPriceAndStockException(book.Price, book.Stock);
        }
    }
}
