using DatabaseMastery.HotCoffeePostgreSQL.Context;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace DatabaseMastery.HotCoffeePostgreSQL.ViewComponents.StatisticsViewComponents
{
    public class _StatisticsTopProductsComponentPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public _StatisticsTopProductsComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var topProducts = _context.Reviews
                .GroupBy(r => r.ProductId)
                .Select(g => new
                {
                    ProductId = g.Key,
                    AverageRating = g.Average(r => r.Rating),
                    ReviewCount = g.Count()
                }).OrderByDescending(x => x.ReviewCount)
                .Take(5)
                .Join(_context.Products,
                r => r.ProductId,
                p => p.ProductId,
                (r, p) => new
                {
                    p.ProductId,
                    p.ProductName,
                    r.ReviewCount,
                    AvgRating = r.AverageRating.ToString("F1", CultureInfo.InvariantCulture)
                }).ToList();
            ViewBag.TopProducts = topProducts;
            return View();
        }
    }
}
