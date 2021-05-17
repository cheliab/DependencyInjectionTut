namespace Tut_05_DI_PropertyInjection
{
    public class CustomerDataAccess: ICustomerDataAccess
    {
        public CustomerDataAccess()
        {
            
        }
        
        public string GetCustomerName(int id)
        {
            return "Customer Name";
        }
    }
}