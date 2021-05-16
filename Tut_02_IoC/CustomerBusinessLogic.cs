namespace Tut_02_IoC
{
    public class CustomerBusinessLogic
    {
        public CustomerBusinessLogic()
        {
            
        }

        public string GetCustomerName(int id)
        {
            DataAccess dataAccess = DataAccessFactory.GetDataAccessObj();

            return dataAccess.GetCustomerName(id);
        }
    }
}