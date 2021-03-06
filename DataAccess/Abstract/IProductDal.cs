﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal :IEntityRepository<Product>
    {
        //Product'u kullanabilmek icin, DataAccess projesine referans ekle dedik ve Entities projesini referans olarak ekledik.
        //Referansi ekledikten sonra using kismini ekledik.

        //Interface metotlari default publictir.
        List<ProductDetailDto> GetProductDetails();
    }
}

//Code Refactoring: Kodun iyilestirilmesidir.