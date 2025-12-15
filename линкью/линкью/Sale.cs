using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace линкью
{
    
    public class Sale
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime SaleDate { get; set; }

        public decimal Total => Quantity * Price;
    }

    // Вспомогательные классы для хранения результатов
    public class CategoryRevenue
    {
        public string Category { get; set; }
        public decimal Revenue { get; set; }
    }

    public class CategoryAverage
    {
        public string Category { get; set; }
        public decimal AverageCheck { get; set; }
    }

    public class CategoryCount
    {
        public string Category { get; set; }
        public int Count { get; set; }
    }

    public class DayRevenue
    {
        public string DayOfWeek { get; set; }
        public decimal Revenue { get; set; }
    }

    public class CategoryStatistics
    {
        public string Category { get; set; }
        public int SalesCount { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal AverageCheck { get; set; }
        public int TotalQuantity { get; set; }
        public decimal MinSale { get; set; }
        public decimal MaxSale { get; set; }
    }
}
