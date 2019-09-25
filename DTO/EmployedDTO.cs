using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public enum ContractTypeName { MonthlySalaryEmployee, HourlySalaryEmployee }
    public class EmployedDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public ContractTypeName contractTypeName { get; set; }
        public int roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public decimal hourlySalary { get; set; }
        public decimal monthlySalary { get; set; }
        public decimal salary { get; set; }
    }
}
