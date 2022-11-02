using AutoMapper;
using SoftUni.Data;
using SoftUni.Dto;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUni.Controllers
{
    public class EmployeeController
    {
        private readonly SoftUniContext context;

        public EmployeeController(SoftUniContext context)
        {
        }

        public EmployeeDtoViewModel GetEmployeeInfo(int id)
        {
            //Initialize the mapper
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<Employee, EmployeeDtoViewModel>());
            var mapper = config.CreateMapper();

            //Using automapper
            var employee = context.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();
            var dto = mapper.Map<EmployeeDtoViewModel>(employee);

            return dto;
        }
    }
}
