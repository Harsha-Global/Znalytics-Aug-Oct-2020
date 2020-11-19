using System;
using System.ServiceModel;
using System.Collections.Generic;

namespace Company
{
    [ServiceContract]
    public interface IProductsService
    {
        [OperationContract]
        Product GetProductByProductID(int id);
    }
}

