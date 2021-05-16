namespace Tut_03_DIP
{
    public class CustomerBusinessLogic
    {
        /// <summary>
        /// В качестве типа теперь используется интерфейс
        /// </summary>
        private ICustomerDataAccess _customerDataAccess;

        public CustomerBusinessLogic()
        {
            _customerDataAccess = DataAccessFactory.GetCustomerDataAccessObj();
        }

        public string GetCustomerName(int id)
        {
            return _customerDataAccess.GetCustomerName(id);
        }
    }
}