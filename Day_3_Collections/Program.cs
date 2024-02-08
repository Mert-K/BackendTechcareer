using System.Threading.Channels;

//Console.WriteLine("Hello, World!");

// List yapısı
// Listeler Referans tiplidir

List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
numbers.Add(11);
numbers.Add(10);
numbers.AddRange(new int[] { 25, 27, 26, 30 });

List<int> evenNumbers = new List<int>();
List<int> oddNumbers = new List<int>();

//1.Yöntem
//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}
//2.Yöntem
//numbers.ForEach(y => Console.WriteLine(y));


//Console.WriteLine($"numbers listesi içerisinde 30 var mı? : {numbers.Contains(30)}");
//Console.WriteLine($"numbers listesi içinde 30 un indexi nedir? : {numbers.IndexOf(30)}");
//Console.WriteLine($"numbers listesi kaç elemanlıdır : {numbers.Count}");

// iki tane listem olacak , numbers listesi içerisindeki tek ve çift sayıları ayıracak ve bunları ekrana bastıracak
// evenNumbers
// oddNumbers



//1. Yöntem
//foreach (var number in numbers)
//{
//    if (number % 2 == 0)
//        evenNumbers.Add(number);
//    else
//        oddNumbers.Add(number);
//}

//2.Yöntem
evenNumbers = numbers.FindAll(x => x % 2 == 0);
oddNumbers = numbers.FindAll(x => x % 2 != 0);

//3. Yöntem
//evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
//oddNumbers = numbers.Where(x => x % 2 != 0).ToList();

Console.WriteLine("Çift sayılar : ");
evenNumbers.ForEach(x => Console.Write($"{x}, "));
Console.WriteLine();
Console.WriteLine("Tek sayılar : ");
oddNumbers.ForEach(x => Console.Write($"{x}, "));


// KENDİ YAPTIĞIM
//numbers.ForEach(i =>
//{
//    if (i % 2 == 0)
//    {
//        evenNumbers.Add(i);
//    }
//    else
//    {
//        oddNumbers.Add(i);
//    }
//});
//Console.WriteLine("Çift Sayilar");
//evenNumbers.ForEach(i => Console.WriteLine(i));
//Console.WriteLine("Tek Sayilar");
//oddNumbers.ForEach(i => Console.WriteLine(i));
