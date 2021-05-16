using System;

namespace Tut_02_IoC
{
    /// <summary>
    /// Inversion of Control
    /// Применение принципа инверсии конроля, чтобы уменьшить связь классов
    /// Класс DataAccess получается через фабричный метод 
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