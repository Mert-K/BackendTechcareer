

//EntityBase class'ını model class'larının ortak olan property'leri için açtık
namespace Day4_BookProject.Models
{
    // Generic programlama
    // Aşağıda generic yapmamızın sebebi , Book ve Category class'larında ortak olan id property'lerinin tiplerini istediğimiz gibi girebilmek içindir. Örneğin Book class'ının Id property'sini int olarak kullanabilirken, Category class'ının Id property'sini string olarak kullanmabilme imkanı için generic abstract class oluşturduk
    public abstract class EntityBase<TId>
    {
        // Guid
        public TId Id { get; set; }
    }
}
