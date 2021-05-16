namespace Tut_03_DIP
{
    /// <summary>
    /// Класс теперь реализует интерфейс
    /// </summary>
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