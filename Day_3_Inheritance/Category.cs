
namespace Day_3_Inheritance;

public class Category : EntityBase
{
    public string CategoryName { get; set; }

    public override string ToString()
    {
        return $"Id : {Id} , Kim Oluşturdu : {CreatedBy}, Ne zaman : {CreatedDate}, Kategori Adı : {CategoryName}";
    }

}
