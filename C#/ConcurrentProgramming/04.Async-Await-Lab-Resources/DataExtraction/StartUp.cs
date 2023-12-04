using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SoftUni
{
    public class StartUp
    {
        static void Main()
        {
            SoftUniContext context = new SoftUniContext();

            Console.WriteLine(GetEmployeWithId1Async(context));

            var days = int.Parse(Console.ReadLine());
            Console.WriteLine(BusinessTripPayment(days));
        }

        public static async Task<decimal> GetEmployeWithId1Async(SoftUniContext context)
        {
            // Make the GetEmployeeWithId1Async() method work asynchronously using async and await
            Employee employe = await context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == 1);

            return employe.Salary;
        }

        public static int BusinessTripPayment(int days)
            => days * 40;

    }
}
