using System;

namespace Tut_03_DIP
{
    /// <summary>
    /// DIP - Dependency inversion principle (Принцип инверсии зависимости)
    ///
    /// Пример применения приниципа инверсии зависимости
    /// Классы DataAccess и CustomerBusinessLogic используют интерфейс
    /// для уменьшения зависимости от конкретного класса
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new CustomerBusinessLogic();
            
            Console.WriteLine(customer.GetCustomerName(1));
            
            Console.ReadLine();
        }
    }
}