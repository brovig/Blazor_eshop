using eShop.CoreBusiness.Models;

namespace eShop.UseCases.AdminPortal.ProcessOrderScreen
{
    public interface IViewOrderDetailUseCase
    {
        Order Execute(int orderId);
    }
}