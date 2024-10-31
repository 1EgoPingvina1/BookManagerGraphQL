namespace BookManagerGraphQL.Domain.Entities;

public class Reviews
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;
    
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public double Rating { get; set; }
    public string Comment { get; set; }
    public DateTime CreatedAt { get; set; }
}