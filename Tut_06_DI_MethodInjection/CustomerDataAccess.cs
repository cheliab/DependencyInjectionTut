namespace Tut_06_DI_MethodInjection
{
    public class CustomerDataAccess: ICustomerDataAccess
    {
        public CustomerDataAccess()
        {
            
        }

        public string GetCustomerName(int id)
        {
            return "Cutomer Name";
        }
    }
}