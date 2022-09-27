using EmployeeSchdule.Extentions;
using EmployeeSchdule.Helper;
using EmployeeSchdule.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace EmployeeSchdule.Controllers
{
    public class ValuesController : ApiController
    {
        EmployeeDbEntities employeeDbEntities;
        ValuesController()
        {
            employeeDbEntities = new EmployeeDbEntities();
        }
        public ListKeyValue Get(int id)
        {
            try
            {
                var employees = employeeDbEntities.Employees.Include(o => o.Breaks)
                           .Include(o => o.Shifts)
                           .Include(o => o.Leaves).Where(o => o.Id == id).FirstOrDefault();
                if (employees == null) return new ListKeyValue();
                return ConvertRawtoFlat(employees);
            }
            catch (System.Exception)
            {
                return new ListKeyValue();
            }
           
        }

        private ListKeyValue ConvertRawtoFlat(Employee employee)
        {
           return employee.RawToFlat();
        }
    }
}
