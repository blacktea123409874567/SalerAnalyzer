using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace линкью
{
    public class SalerAnalyzer
    {
        private List<Sale> _sales;
        public SalerAnalyzer(List<Sale> sales) 
        {
            _sales = sales ?? new List<Sale>();
        }

       /// <summary>
       /// return total выручку
       /// </summary>
       /// <returns></returns>
        public decimal GetToRevenue()
        {
            return _sales.Sum(x => x.Total);
        }

        public List<CategoryRevenue> GetToRevenueByCategory()
        {
            return _sales
                .GroupBy(x => x.Category)
                .Select(x => new CategoryRevenue
                {
                    Category = x.Key,
                    Revenue = x.Sum(c =>c.Total)
                })
                .OrderByDescending(c => c.Revenue)
                .ToList();
        }

        public List<CategoryAverage> GetToAverageByCategory()
        {
            return _sales
                .GroupBy(x => x.Category)
                .Select(x => new CategoryAverage
                {
                    Category = x.Key,
                    AverageCheck = x.Average(c => c.Total)
                })
                .OrderByDescending(c => c.AverageCheck)
                .ToList();
        }
        public List<CategoryCount> GetToCountByCategory()
        {
            return _sales
                .GroupBy(x => x.Category)
                .Select(x => new CategoryCount
                {
                    Category = x.Key,
                    Count = x.Sum(c => c.Quantity)
                })
                .OrderByDescending(c => c.Count)
                .ToList();
        }



        public List<Sale> Topthree()
        {
            return _sales.OrderByDescending(x => x.Total)
                         .Take(3)
                         .ToList<Sale>();
        }
    }
}
