namespace Tut_06_DI_MethodInjection
{
    public class CustomerService
    {
        private CustomerBusinessLogic _customerBusinessLogic;

        public CustomerService()
        {
            _customerBusinessLogic = new CustomerBusinessLogic();
            _customerBusinessLogic.SetDependency(new CustomerDataAccess());
        }

        public string GetCustomerName(int id)
        {
            return _customerBusinessLogic.GetCustomerName(id);
        }
    }
}