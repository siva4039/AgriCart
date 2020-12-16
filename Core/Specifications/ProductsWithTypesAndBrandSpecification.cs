using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandSpecification : BaseSpecifications<Product>
    {
        public ProductsWithTypesAndBrandSpecification()
        {
            AddInclude(x => x.ProductType);
            AddInclude(x=> x.ProductBrand);
        }

        public ProductsWithTypesAndBrandSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x=> x.ProductBrand);

        }
    }
}