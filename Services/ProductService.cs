using BlazorApp2.Models;

namespace BlazorApp2.Services;

public class ProductService
{
    public Task<List<Product>> GetAllAsync()
    {
        return Task.FromResult(new List<Product>
        {
            new() { Name="Apple iMac", Category="Computers", Brand="Apple", Price=1299, Stock=50, TotalSales=200, Status="In Stock" },
            new() { Name="PlayStation 5", Category="Gaming", Brand="Sony", Price=499, Stock=10, TotalSales=500, Status="Out of Stock" },
            new() { Name="Samsung Galaxy", Category="Mobile Phones", Brand="Samsung", Price=899, Stock=80, TotalSales=150, Status="In Stock" },
        });
    }
}
