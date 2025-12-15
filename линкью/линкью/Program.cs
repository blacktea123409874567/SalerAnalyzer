namespace линкью
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sale> sales = new List<Sale>
            {
                new Sale { Id = 1, ProductName = "Ноутбук", Category = "Электроника",
                           Quantity = 1, Price = 50000, SaleDate = new DateTime(2024, 1, 15) },
                new Sale { Id = 2, ProductName = "Мышь", Category = "Электроника",
                           Quantity = 2, Price = 1500, SaleDate = new DateTime(2024, 1, 15) },
                new Sale { Id = 3, ProductName = "Стул", Category = "Мебель",
                           Quantity = 1, Price = 3000, SaleDate = new DateTime(2024, 1, 16) },
                new Sale { Id = 4, ProductName = "Монитор", Category = "Электроника",
                           Quantity = 1, Price = 20000, SaleDate = new DateTime(2024, 1, 16) },
                new Sale { Id = 5, ProductName = "Книга", Category = "Книги",
                           Quantity = 3, Price = 500, SaleDate = new DateTime(2024, 1, 17) },
                new Sale { Id = 6, ProductName = "Стол", Category = "Мебель",
                           Quantity = 1, Price = 7000, SaleDate = new DateTime(2024, 1, 17) },
                new Sale { Id = 7, ProductName = "Наушники", Category = "Электроника",
                           Quantity = 2, Price = 3000, SaleDate = new DateTime(2024, 1, 17) }
            };
            var groupedByCategory = sales.GroupBy(s => s.Category);

            Console.WriteLine("Продажи по категориям:");
            foreach (var group in groupedByCategory)
            {
                Console.WriteLine($"\nКатегория: {group.Key}");
                foreach (var sale in group)
                {
                    Console.WriteLine($"  {sale.ProductName}: {sale.Quantity} × {sale.Price:C} = {sale.Total:C}");
                }
            }
            //var mountgroup = sales.GroupBy(x => x.SaleDate.ToString("MM"));

            //foreach (var group in sales.GroupBy(x => (x.Quantity<2)? "low" :$" {((x.Quantity>5)? "high":"medium")}"))
            //{

            //}
            var counOnCategory = sales
                .GroupBy(x => x.Category)
                .Select(x => new 
                {
                Category = x.Key,
                totaly = x.Sum(s => s.Quantity),
                });
            
        }
    }

}