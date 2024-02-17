// Seneryo Ürünler ve kategori listeleri üzerinden çeşitli örnekler yapacağız.

using Day_5_Linq.Data;
using Day_5_Linq.Models;
using System.Reflection.Metadata.Ecma335;

var products = Repository.Products;
var categories = Repository.Categories;

// Tüm ürünlerden CategoryId'si 1 olan ürünleri listeleyin.


// 1. Yöntem
//foreach (var product in products)
//{
//    if(product.CategoryId==1)
//    {
//        Console.WriteLine(product);
//    }
//}


// 2. Yöntem
//var prodList = from p in products where p.CategoryId == 1 select p;

//foreach (var p in prodList)
//{
//    Console.WriteLine(p);
//}

// 3. Yöntem
//products.Where(p => p.CategoryId == 1).ToList().ForEach(p => Console.WriteLine(p));


// Tüm ürünlerden içerisinde App geçen ürünleri listeleyin

// 1. Yöntem
//foreach (var p in products)
//{
//    if (p.Name.Contains("App"))
//    {
//        Console.WriteLine(p);
//    }
//}

// 2. Yöntem
//var pList = from p in products where p.Name.Contains("App") select p;
//foreach (var p in pList)
//{
//    Console.WriteLine(p);
//}

// 3. Yöntem
//products.Where(p => p.Name.Contains("App")).ToList().ForEach(p => Console.WriteLine(p));


// Ürünlerin fiyatlarının toplamını bulan kodu yazınız.
// 1. Yöntem
//double total = 0;
//foreach (var p in products)
//{
//    total += p.Price;
//}
//Console.WriteLine("Tüm ürünlerin toplamı : " + total);

// 2. Yöntem
//double total = products.Sum(p => p.Price);
//Console.WriteLine($"Tüm ürünlerin fiyatlarının toplamı : {total}");


// Todo : CategoryId'si 2 olan ürünlerin Price toplamlarını bulunuz.
//double total = products.Where(p=>p.CategoryId==2).Sum(p=>p.Price);
//Console.WriteLine($"CategoryId si 2 olan ürünlerin toplamı : {total}");

// Todo : Tüm ürünlerin fiyat ortalamasını alan kodu yazınız.
//var average = products.Average(p => p.Price);
//Console.WriteLine($"Tüm ürünlerin fiyatlarının ortalaması : {average}");

// Todo : CategoryId si 3 olan ürün var mı?
//var productIsPresent = products.Any(p => p.CategoryId == 4);
//Console.WriteLine($"Category Id si 4 olan ürün var mı : {productIsPresent}");

// Todo : Ürünün id si 1 olan ürünün değerlerini ekrana basınız
//var product = products.SingleOrDefault(p=>p.Id==5);
//Console.WriteLine(product);

// todo: Tüm ürünlerin sadece isimlerini ekrana bastırınız.
//products.Select(p => p.Name).ToList().ForEach(s => { Console.WriteLine(s); });

// todo: Tüm ürünlerin isim stok ve price değerlerini ekrana bastıran kodu yazınız.
// 1. Yöntem
//var list = products.Select(p => new { Name = p.Name, Stock = p.Stock, Price = p.Price }).ToList();
//foreach (var item in list)
//{
//    Console.WriteLine($"İsim : {item.Name}, Stok : {item.Stock}, Fiyat : {item.Price}");

//}

//2. Yöntem
//var list = from p in products select new { isim = p.Name, stok = p.Stock, price = p.Price };
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}


// todo: CategoryId'lerine göre ürünleri gruplandıralım
//var grouppedProducts = products.GroupBy(x => x.CategoryId).ToDictionary(g => g.Key, g => g.ToList());
//foreach (var group in grouppedProducts)
//{
//    Console.WriteLine($"{group.Key} Category Id sine sahip ürünler");
//    group.Value.ForEach(x => Console.WriteLine(x));
//}


// Tüm ürünleri fiyatları artacak şekilde sıralayınız.
//products.OrderBy(p=>p.Price).ToList().ForEach(p =>Console.WriteLine(p));

// TODO: Tüm ürünlerin fiyatını azalan bir şekilde sıralayınız.
//products.OrderByDescending(p => p.Price).ToList().ForEach(p => Console.WriteLine(p));

//JOIN işlemi
// 1.Yöntem
//var details = from p in products
//              join c in categories on p.CategoryId equals c.Id
//              select new ProductDetailDto
//              {
//                  CategoryName = c.Name,
//                  Price = p.Price,
//                  ProductId = p.Id,
//                  ProductName = p.Name,
//                  Stock = p.Stock
//              };
//foreach (var item in details)
//{
//    Console.WriteLine(item);
//}

// 2.Yöntem
//var lambdaJoin = products.Join(categories,
//    p => p.CategoryId,
//    c => c.Id,
//    (product, category) => new ProductDetailDto
//    {
//        ProductId = product.Id,
//        ProductName = product.Name,
//        Price = product.Price,
//        Stock = product.Stock,
//        CategoryName = category.Name
//    }).ToList();

//lambdaJoin.FindAll(p => p.CategoryName == "Telefon").ForEach(ProductDetailDto => Console.WriteLine(ProductDetailDto));


// Todo : Öyle bir sistem dizayn edin ki ProductDetail listesini dönsün ama kategori id'si 2 olan ürünlerin detay listesi olsun.

//products
//    .Where(p => p.CategoryId == 2)
//    .Join(categories, p => p.CategoryId, c => c.Id, (Product product, Category category) => new ProductDetailDto
//    {
//        ProductId = product.Id,
//        ProductName = product.Name,
//        Price = product.Price,
//        Stock = product.Stock,
//        CategoryName = category.Name
//    }).ToList().ForEach(pDD => Console.WriteLine(pDD));


List<int> numbers1 = new List<int>() { 1, 2, 3, 4, 5 };
List<int> numbers2 = new() { 4, 5, 6, 7, 8 };
List<int> numbers3 = new() { 1, 1, 2, 2, 3, 3, 10, 4, 5 };

// TODO : 2 sayı listesinde ortak sayıları tek liste halinde listeleyelim
//numbers1.Intersect(numbers2).ToList().ForEach(x=>Console.WriteLine(x));

// Todo : 1. sayı listesinde bulunan ama 2. sayı listesinde bulunmayan sayıların listesini ekrana yazdıran kod
//numbers1.Except(numbers2).ToList().ForEach(x => Console.WriteLine(x));

// Todo : 1. sayı listesinde bulunan ama 2. sayı listesinde bulunmayan sayıları 2. listenin üzerine ekleyip yazdır
//numbers1.Except(numbers2).ToList().ForEach(x=>numbers2.Add(x));
//numbers2.ForEach(x => Console.WriteLine(x));


// TODO : 1. Sayı Listesinde bulunan sayıların çarpımını 
//Console.WriteLine(numbers1.Aggregate((a, b) => a * b)); //burada mantık 1*2 yapıp a'ya atıyor. Sonra a*3 yapıyor. Yani 1*2*3 olup yine a ya atıyor. Sonra a*b yani (1*2*3)*4 yapıyor ve a'ya atıyor. En sonra a*5 yapıp nihai sonucu geri döndürüyor. Yani 1*2*3*4*5

// TODO : 3. sayı listesinde bulunan benzersiz sayılar
//numbers3.Distinct().ToList().ForEach(x => Console.WriteLine(x));


// TODO : 3 sayı listesini tek liste haline getirme
//numbers1.Concat(numbers2).Concat(numbers3).ToList().ForEach(x =>Console.Write($"{x}, "));


// Todo : Sayı 2 listesinde en büyük ve en küçük değeri ekrana yazın.
//Console.WriteLine($"numbers2 listesinde en küçük sayı : {numbers2.Min()}, en büyük sayı ise : {numbers2.Max()}");


// TODO : sayi2 listesinde 2 den büyük 3 tane sayı alan yeni listeyi yazdırın.
//numbers2.Where(x => x > 2).Take(3).ToList().ForEach(x => Console.WriteLine(x));


