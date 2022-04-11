using eShop.CoreBusiness.Models;
using System.Collections.Generic;

namespace eShop.UseCases.AdminPortal.OutstandingOrdersScreen
{
    public interface IViewOutstandingOrdersUseCase
    {
        IEnumerable<Order> Execute();
    }
}