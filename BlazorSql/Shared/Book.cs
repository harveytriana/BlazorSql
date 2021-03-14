// ======================================
//  Blazor Spread. LHTV
// ======================================
using System.ComponentModel.DataAnnotations;

namespace BlazorSql.Shared
{
    public class Book
    {
        [Key] public int BookId { get; set; }
        [MaxLength(014)] public string ISBN { get; set; }
        [MaxLength(100)] public string Author { get; set; }
        [MaxLength(100)] public string Language { get; set; }
        [MaxLength(100)] public string Link { get; set; }
        [MaxLength(100)] public string Title { get; set; }
        public int Year { get; set; }

        public override string ToString() => $"{Title}, {Author}";
    }
}
