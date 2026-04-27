public class WishlistItem
{
    public int Id { get; set; }

    // Links to the logged-in user (ASP.NET Core Identity uses strings for User IDs)
    public string UserId { get; set; }

    // Links to the specific product
    public int ProductId { get; set; }

    // Navigation Property
    public Product? Product { get; set; }
}