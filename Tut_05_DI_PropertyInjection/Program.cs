using System;

namespace Tut_05_DI_PropertyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService();
            var name = customerService.GetCustomerName(1);

            Console.WriteLine(name);
            
            Console.ReadLine();
        }
    }
}