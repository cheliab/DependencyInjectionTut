namespace Tut_06_DI_MethodInjection
{
    public class CustomerBusinessLogic: IDataAccessDependency
    {
        private ICustomerDataAccess _dataAccess;

        public CustomerBusinessLogic()
        {
        }

        public string GetCustomerName(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
        
        /// <summary>
        /// Реализуем интерфейс с инъекцией зависимости
        /// Этот метод будет использоваться в классе сервиса для передачи класса с данными
        /// </summary>
        /// <param name="customerDataAccess"></param>
        public void SetDependency(ICustomerDataAccess customerDataAccess)
        {
            _dataAccess = customerDataAccess;
        }
    }
}