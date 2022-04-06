using System;

namespace LINQSamples
{
    public partial class ProductStats
    {
        public ProductStats()
        {
            Max = Decimal.MinValue;
            Min = Decimal.MaxValue;

            TotalProducts = 0;
            Total = 0;
        }

        public int TotalProducts { get; set; }
        public decimal Max { get; set; }
        public decimal Min { get; set; }
        public decimal Total { get; set; }
        public decimal Average { get; set; }

        public ProductStats Accumulate(Product prod)
        {
            // Increment total number of products
            TotalProducts += 1;

            // Add to total list price
            Total += prod.ListPrice;

            // Calculate Max and Min
            Max = Math.Max(Max, prod.ListPrice);
            Min = Math.Min(Min, prod.ListPrice);

            return this;
        }

        public ProductStats ComputeAverage()
        {
            Average = Total / TotalProducts;

            return this;
        }
    }
}
