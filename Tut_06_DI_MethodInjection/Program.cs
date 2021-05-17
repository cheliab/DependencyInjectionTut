using System;

namespace Tut_06_DI_MethodInjection
{
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