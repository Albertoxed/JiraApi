using ApiJira.Dto;
using ApiJira.Models;
using ApiJira.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJira.Controllers
{
    public class EmployeesController : BaseController<Employee, EmployeeDto>
    {
        public EmployeesController(IEmployeeService userService) : base(userService)
        {

        }
    }
}
