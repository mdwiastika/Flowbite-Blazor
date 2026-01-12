namespace BlazorApp2.Models;

public class Product
{
    public string Name { get; set; } = "";
    public string Category { get; set; } = "";
    public string Brand { get; set; } = "";
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int TotalSales { get; set; }
    public string Status { get; set; } = "";
}
