using BlazorApp2.Components.Navigation.Sidebar;
using static BlazorApp2.Components.Navigation.Sidebar.SidebarDropdown;

namespace BlazorApp2.Components.Navigation
{
    public class SidebarConfig
    {
        public static List<DropdownMenuConfig> GetDropdownMenus()
        {
            return new List<DropdownMenuConfig>
            {
                new DropdownMenuConfig
                {
                    Key = "Master",
                    Title = "Master Data",
                    Prefix = "master",
                    IconSvg = Icons.MasterData,
                    Items = new List<SidebarMenuItem>
                    {
                        new() { Href = "/master/category", Label = "Category" },
                        new() { Href = "/master/product", Label = "Product" },
                        new() { Href = "/master/invoice", Label = "Invoice" }
                    }
                },
                new DropdownMenuConfig
                {
                    Key = "Transaction",
                    Title = "Transaction",
                    Prefix = "transaction",
                    IconSvg = Icons.Transaction,
                    Items = new List<SidebarMenuItem>
                    {
                        new() { Href = "/transaction/orders", Label = "Orders" },
                        new() { Href = "/transaction/payments", Label = "Payments" }
                    }
                },
                new DropdownMenuConfig
                {
                    Key = "Setting",
                    Title = "Setting",
                    Prefix = "setting",
                    IconSvg = Icons.Setting,
                    Items = new List<SidebarMenuItem>
                    {
                        new() { Href = "/setting/users", Label = "Users" },
                        new() { Href = "/setting/roles", Label = "Roles" }
                    }
                },
                new DropdownMenuConfig
                {
                    Key = "Report",
                    Title = "Report",
                    Prefix = "report",
                    IconSvg = Icons.Report,
                    Items = new List<SidebarMenuItem>
                    {
                        new() { Href = "/report/sales", Label = "Sales" },
                        new() { Href = "/report/summary", Label = "Summary" }
                    }
                },
                new DropdownMenuConfig
                {
                    Key = "Import",
                    Title = "Import",
                    Prefix = "import",
                    IconSvg = Icons.Import,
                    Items = new List<SidebarMenuItem>
                    {
                        new() { Href = "/import/products", Label = "Products" }
                    }
                }
            };
        }
    }

    public class DropdownMenuConfig
    {
        public string Key { get; set; } = "";
        public string Title { get; set; } = "";
        public string Prefix { get; set; } = "";
        public string IconSvg { get; set; } = "";
        public List<SidebarMenuItem> Items { get; set; } = new();
    }
}