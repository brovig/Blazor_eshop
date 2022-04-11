using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;

namespace eShop.UseCases.AdminPortal.ProcessOrderScreen
{
    public class ViewOrderDetailUseCase : IViewOrderDetailUseCase
    {
        private readonly IOrderRepository orderRepository;

        public ViewOrderDetailUseCase(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public Order Execute(int orderId)
        {
            return orderRepository.GetOrder(orderId);
        }
    }
}