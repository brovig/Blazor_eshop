namespace eShop.UseCases.AdminPortal.ProcessOrderScreen
{
    public interface IProcessOrderUseCase
    {   
        bool Execute(int orderId, string adminUserName);
    }
}