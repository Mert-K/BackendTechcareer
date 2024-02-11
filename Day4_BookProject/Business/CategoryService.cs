using Day4_BookProject.Data;
using Day4_BookProject.Exceptions;
using Day4_BookProject.Models;

namespace Day4_BookProject.Business;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    //Kategori adı minimum 3 karakterli olmalıdır.
    public void Add(Category category)
    {
        try
        {
            AddRules(category);
            _categoryRepository.Add(category);
            GetList();
        }
        catch (CategoryNameException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Delete(string id)
    {
        try
        {
            _categoryRepository.Delete(id);
            GetList();
        }
        catch (CategoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetById(string id)
    {
        try
        {
            Category category =  _categoryRepository.GetById(id);
            Console.WriteLine(category);
        }
        catch (CategoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetList()
    {
        //alt alta yazmak clean kod tekniğidir
        _categoryRepository
            .GetAll()
            .ForEach(c => { Console.WriteLine(c); });
    }

    public void AddRules(Category category)
    {
        if (category.Name.Length < 3)
        {
            throw new CategoryNameException(category.Name);
        }
    }
}
