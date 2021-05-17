using System;

namespace Tut_04_DI_ConstructorInjection
{
    /// <summary>
    /// DI - Dependency Injection - Constructor injection
    /// Пример использования инъекции зависимости в конструкторе класса
    ///
    /// Теперь CustomerDataAccess попадает в класс CustomerBusinessLogic через инъекцию зависимости в конструктор
    /// Инъекция выполняется в классе CustomerService
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService();
            
            Console.WriteLine(customerService.GetCustomerName(1));
            
            Console.ReadLine();
        }
    }
}