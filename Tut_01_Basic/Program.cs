using System;

namespace Tut_01_Basic
{
    /// <summary>
    /// Пример простого дизайна классов
    /// с максимальной зависимостью
    /// CustomerBusinessLogic зависит от DataAccess класса
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