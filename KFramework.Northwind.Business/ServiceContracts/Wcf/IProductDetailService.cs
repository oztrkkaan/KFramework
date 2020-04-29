using KFramework.Northwind.Entities.DTOs;
using System.Collections.Generic;
using System.ServiceModel;

namespace KFramework.Northwind.Business.ServiceContracts.Wcf
{
    [ServiceContract]
    public interface IProductDetailService
    {
        [OperationContract]
        List<ProductDto> GetAll();
    }
}
