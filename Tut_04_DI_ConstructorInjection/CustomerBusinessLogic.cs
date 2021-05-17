namespace Tut_04_DI_ConstructorInjection
{
    public class CustomerBusinessLogic
    {
        private readonly ICustomerDataAccess _dataAccess;

        /// <summary>
        /// Делаем инъекцию зависимости в конструктор класса
        /// </summary>
        /// <param name="dataAccess"></param>
        public CustomerBusinessLogic(ICustomerDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public CustomerBusinessLogic()
        {
            _dataAccess = new CustomerDataAccess();
        }

        public string ProcessCustomerData(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }
}