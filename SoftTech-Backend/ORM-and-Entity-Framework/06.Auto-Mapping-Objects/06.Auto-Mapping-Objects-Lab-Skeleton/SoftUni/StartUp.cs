using AutoMapper;
using SoftUni.Controllers;
using SoftUni.Data;
using SoftUni.Dto;
using SoftUni.Models;
using System;

namespace SoftUni
{
    public class StartUp
    {
        static void Main()
        {
            var context = new SoftUniContext();

            Console.WriteLine("Write the id of an Employee to get his information.");

            var employeeInfoRequest = int.Parse(Console.ReadLine());

            var employeeController = new EmployeeController(context);

            var employeeInfoResult = employeeController.GetEmployeeInfo(employeeInfoRequest);
        }
    }
}
