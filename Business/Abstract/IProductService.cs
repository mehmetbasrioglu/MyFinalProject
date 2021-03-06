using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //abstract soyut demek
    public interface IProductService
    {
        List<Product> GetAll();

    }
}
