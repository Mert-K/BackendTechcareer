
using Day4_BookProject.Models;

namespace Day4_BookProject.Business;

public interface ICategoryService
{
    void GetList();
    void Add(Category category);
    void Delete(string id);
    void GetById(string id);
}
