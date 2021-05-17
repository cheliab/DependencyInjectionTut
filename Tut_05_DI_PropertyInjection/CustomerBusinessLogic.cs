namespace Tut_05_DI_PropertyInjection
{
    public class CustomerBusinessLogic
    {
        public ICustomerDataAccess DataAccess { get; set; }
        
        public CustomerBusinessLogic()
        {
        }

        public string GetName(int id)
        {
            return DataAccess.GetCustomerName(id);
        }
    }
}