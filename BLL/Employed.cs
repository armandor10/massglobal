using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL;
using DTO;

namespace BLL
{
    public class Employed
    {
        private EmployedDTO getAnnualSalary(EmployedDTO emp)
        {
            emp.salary = emp.contractTypeName == ContractTypeName.HourlySalaryEmployee ?
                120 * (emp.hourlySalary * 12) : emp.monthlySalary * 12;
            return emp;
        }
        public ResponseDTO getEmployes()
        {
            var resp = new DAL.Employed().getEmployes();
            resp.data = ((List<EmployedDTO>)resp.data)
                            .Select(getAnnualSalary)
                            .ToList();
            return resp;
        }

        public ResponseDTO getEmployed(int id)
        {
            var resp = new DAL.Employed().getEmployes();
            resp.data = ((List<EmployedDTO>)resp.data)
                            .Where(e => e.id == id)
                            .Select(getAnnualSalary)
                            .FirstOrDefault();
            return resp;
        }

    }
}
