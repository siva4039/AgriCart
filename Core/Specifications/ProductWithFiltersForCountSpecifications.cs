using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithFiltersForCountSpecifications: BaseSpecifications<Product>
    {
        public ProductWithFiltersForCountSpecifications(ProductSpecParams productParams) : base(x=>
        (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))
            &&(!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId) 
              && (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId)
        )
        {
        }
    }
}