using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandSpecification : BaseSpecifications<Product>
    {
        public ProductsWithTypesAndBrandSpecification(string sort, int? brandId, int? typeId)
        :base(x=> 
        (
            (!brandId.HasValue || x.ProductBrandId == brandId) && (!typeId.HasValue || x.ProductTypeId == typeId)

        ))
        {
            AddInclude(x => x.ProductType);
            AddInclude(x=> x.ProductBrand);
            AddOrderBy(x => x.Name);

            if(!string.IsNullOrEmpty(sort))
            {
                switch(sort)
                {
                    case "priceAsc" :
                            AddOrderBy(p => p.Price);
                            break;

                    case "priceDsc" :
                            AddOrderByDecending(p => p.Price);
                            break;

                    default :
                            AddOrderBy(n=>n.Name);
                            break;
                }
            }



        }

        public ProductsWithTypesAndBrandSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x=> x.ProductBrand);

        }
    }
}