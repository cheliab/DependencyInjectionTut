namespace Tut_04_DI_ConstructorInjection
{
    public class CustomerService
    {
        private CustomerBusinessLogic _customerBusinessLogic;

        public CustomerService()
        {
            _customerBusinessLogic = new CustomerBusinessLogic();
        }

        public string GetCustomerName(int id)
        {
            return _customerBusinessLogic.ProcessCustomerData(id);
        }
    }
}