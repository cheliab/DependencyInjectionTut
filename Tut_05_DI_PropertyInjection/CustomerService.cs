namespace Tut_05_DI_PropertyInjection
{
    public class CustomerService
    {
        private readonly CustomerBusinessLogic _customerBusinessLogic;

        public CustomerService()
        {
            _customerBusinessLogic = new CustomerBusinessLogic();
            _customerBusinessLogic.DataAccess = new CustomerDataAccess();
        }

        public string GetCustomerName(int id)
        {
            return _customerBusinessLogic.GetName(id);
        }
    }
}