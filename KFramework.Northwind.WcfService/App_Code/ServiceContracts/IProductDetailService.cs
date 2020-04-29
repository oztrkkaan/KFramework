using KFramework.Northwind.Entities.DTOs;
using System.Collections.Generic;
using System.ServiceModel;

/// <summary>
/// Summary description for IProductDetailService
/// </summary>
/// 
[ServiceContract]
public interface IProductDetailService
{
    [OperationContract]
    List<ProductDto> GetAll();
}