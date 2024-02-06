// Person adında bir class oluşturulur ve gerekli işlemler yapılır.
// Oluşturulan nesnelerin ekrana bastırılması

//classlar referans tiplidir.
//referans tipler oluşturulurken new anahtar sözcüğüyle oluşturulur.

using Day_2_OOP;

int a = 3;

//1.Yöntem
Person person = new();
person.name = "Ömer";
person.age = 25;
person.surname = "Doğan";
person.phone = "0123456789";
//Console.WriteLine(person);

//2. Yöntem
Person person1 = new Person();
person1.name = "t";
person1.age = 15;
person1.surname = "Şahin";
person1.phone = "          ";

Person.Add(person1);

////3. Yöntem
var person2 = new Person(25,"Evren","Çakar","05341022567894");
person2.name = "Ahmet";
Console.WriteLine(person2);


KayitOl kayitOl = new(username:"deneme",password:"deneme");
kayitOl.Success();

KayitOl kayitOl1 = new(username: "deneme", password: "deneme",city:"Malatya",state:"Doğu Anadolu");
kayitOl1.Success();

Person person3 = new()
{
    name = "asdasd",
    age = 25,
    phone = "12345",
    surname = "KASDJASDJKASD"
};
Console.WriteLine(person3);

// struct -> Yapı olarak karşımıza gelir
// record -> immutable data classlardır

Product product = new Product(Name:"Deneme",Description:"Deneme",Price:25); //record

Console.WriteLine(product);


Book book;
book.Adi = "Abasıyanık";
book.Yazar = "Sait Faik";
book.SayfaSayisi = 125;
Console.WriteLine(book);

//****************Struct*****************
// Struct'lar değer tipindedir.
// Bellekte stack hafızada tutulur.
// new Anahtar sözcüğü kullanmadan oluşturulabilir
// Büyük veri setleri için değil, küçük veri setleri için uygundur
// Structlar bir classtan miras alamazlar, sadece interface'den miras alabilirler

//****************Record*****************
//.Net 5 ve C#9.0 ile geldi
// Recordların temel amacı veriyi saklamak, genellikle adına veri taşıyıcıları da denir
// Immutable yapılardır.