using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Exceptions
{
    public class CategoryNameException : Exception
    {
        public CategoryNameException(string id) : base($"Kategori adı {id.Length} karakterli. Kategori adı minimum 3 karakterli olmalıdır.")
        {

        }
    }
}
