namespace Tut_04_DI_ConstructorInjection
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