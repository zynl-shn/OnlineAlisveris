﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete.EntityFramework;

public class EfProductCategoryDal: EfEntityRepositoryBase<ProductCategory,ShopOnlineContext>, IProductCategoryDal
{
    
}