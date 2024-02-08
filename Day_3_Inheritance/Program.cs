
// CRUD = Create - Read - Update - Delete
using Day_3_Inheritance;
using Day_3_Inheritance.Manager;
using System.ComponentModel.Design;



// Interface'ler anlaşmadır
// Interfaceler Soyut class'lardır yani new anahtar sözcüğü ile nesnesi üretilemez.


// Product ve Category diye 2 tane veri tabanı tablomuzun olduğunu düşünelim.Bu tablolar arasında basit crud operasyonlarını yapınız.

//Category category = new Category()
//{
//    Id = 1,
//    CreatedBy = "Gülsu Doğan",
//    CreatedDate = "2023",
//    CategoryName = "Bilgisayar",
//};

//Product product = new Product()
//{
//    Id = 2,
//    CreatedBy = "Gülsu Doğan",
//    CreatedDate = "2023",
//    Name = "Msi",
//    Price = 1200
//};
//Console.WriteLine(category);
//Console.WriteLine(product);


ICrudService crudService = new CategoryService();
crudService.Add();
crudService.Delete();
crudService.GetAll();
crudService.Update();


