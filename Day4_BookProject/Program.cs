// Kitap ekleme listeleme ve silme gibi operasyonları simüle edeceğiz
// veri tabanı gibi çalışan bir liste kullanacağız


using Day4_BookProject.Business;
using Day4_BookProject.Data;
using Day4_BookProject.Exceptions;
using Day4_BookProject.Models;
//Dapper (EntityFrameWork'ün rakiplerinde biri)


//IBookService bookService = new BookService(new BookRepository());
////bookService.GetList();

//Book book = new Book()
//{
//    Id=5,
//    Description = "Test",
//    Price = 2500,
//    Stock = -2000,
//    Title = "Test"
//};

//Console.WriteLine("Kayıt ekleme : ");
//bookService.Add(book);
//Console.WriteLine("Kayıt silme : ");
//bookService.Delete(2);

//Console.WriteLine("Id ye göre getirme");
//bookService.GetById(2);

//Console.WriteLine("Kitapların Listesi");
//bookService.GetList();


ICategoryService categoryService = new CategoryService(new CategoryRepository());
categoryService.GetList();

Console.WriteLine("\nGETBYID'ye göre BULMA");
categoryService.GetById("B");

Console.WriteLine("\nGETBYID'ye göre BULMA");
categoryService.GetById("X");

Console.WriteLine("\n KATEGORI EKLEME");
categoryService.Add(new Category()
{
    Id = "D",
    Name = "Kurgu"
});

Console.WriteLine("\nkategori ekleme");
categoryService.Add(new Category()
{
    Id= "E",
    Name="Mer"
});