
namespace Day4_BookProject.Exceptions;

public class CategoryNotFoundException : Exception
{
    public CategoryNotFoundException(string id):base($"{id}' numaralı Id'ye ait Kategori Bulunamadı.")
    {
        
    }
}
