using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Inheritance.Manager;

public class ProductService : ICrudService
{
    public void Add()
    {
        Console.WriteLine("Ürün eklendi");
    }

    public void Delete()
    {
        Console.WriteLine("Ürün silindi");
    }

    public void GetAll()
    {
        Console.WriteLine("Ürünler listelendi");
    }

    public void Update()
    {
        Console.WriteLine("Ürün güncellendi");
    }
}
