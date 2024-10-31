namespace BookManagerGraphQL.Domain.Entities;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int StatusId { get; set; }
    public Status Status { get; set; }
    
    public string Description { get; set; }
    
    public int OwnerId { get; set; }
    public User Owner { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
}
