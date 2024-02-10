using Day4_BookProject.Data;

namespace Day4_BookProject.Business;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public void GetList()
    {
        //alt alta yazmak clean kod tekniğidir
        _categoryRepository
            .GetAll()
            .ForEach(c => { Console.WriteLine(c); });
    }
}
