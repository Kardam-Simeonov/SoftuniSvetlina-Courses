using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftUni.Data;

namespace SoftUni
{
    public class StartUp
    {
        static void Main()
        {
            var context = new SoftUniContext();

        }

        public static string FindTownsStartingWith(SoftUniContext context, string letter)
        {
            var towns = context.Towns
                .Where(t => t.Name.StartsWith(letter))
                .Join(context.Addresses, t => t.TownId, a => a.TownId, (t, a) => new
                {
                    TownName = t.Name,
                    AddressText = a.AddressText,
                    EmployeeCount = a.Employees.Count
                })
                .ToList();

            return String.Join("\n", towns.Select(t => $"{t.TownName} {t.AddressText}"));
        }
        public static string EmployeeWithProjects(SoftUniContext context, int employeeId)
        {
            var employeeProjects = context.EmployeesProjects.Join(context.Projects, ep => ep.ProjectId, p => p.ProjectId, (ep, p) => new
            {
                EmployeeId = ep.EmployeeId,
                ProjectName = p.Name
            })
             .Where(ep => ep.EmployeeId == employeeId)
             .ToList();

            var employee= context.Employees
                .Where(e => e.EmployeeId == employeeId)
                .Select(e => e.FirstName)
                .FirstOrDefault();

            return employee + " " + String.Join($"\n{employee}", employeeProjects);
        }

    }
}
