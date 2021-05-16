namespace Tut_03_DIP
{
    /// <summary>
    /// В фабричном методе так же используем интерфейс
    ///
    /// За счет этого можно будет легко подменить класс в фабрике
    /// </summary>
    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }
}