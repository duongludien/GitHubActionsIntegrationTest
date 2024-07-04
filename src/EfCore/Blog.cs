using System.ComponentModel.DataAnnotations;

namespace EfCore;

public class Blog
{
    public int BlogId { get; set; }
    
    [MaxLength(32)]
    public string Url { get; set; } = null!;
    
    [MaxLength(32)]
    public string Title { get; set; } = null!;
    
    [MaxLength(32)]
    public string Content { get; set; } = null!;
}