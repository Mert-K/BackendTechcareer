﻿using Day4_BookProject.Exceptions;
using Day4_BookProject.Models;

namespace Day4_BookProject.Data;
//EXCEPTION'LARI YAZ.
public class CategoryRepository : ICategoryRepository
{

    private readonly List<Category> _categories;

    public CategoryRepository()
    {
        _categories = new List<Category>()
        {
            new Category{Id="A",Name="Polisiye"},
            new Category{Id="B",Name="Tarih"},
            new Category{Id="C",Name="Psikoloji"},
        };
    }


    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Delete(string id)
    {
        Category? category = _categories.SingleOrDefault(c => c.Id == id);
        if (category is null)
        {
            throw new CategoryNotFoundException(id);
        }
        _categories.Remove(category);
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public Category? GetById(string id)
    {
        Category? category = _categories.FirstOrDefault(c => c.Id == id);
        if (category is null)
        {
            throw new CategoryNotFoundException(id);
        }
        return category;
    }
}
