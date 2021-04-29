using System.Collections.Generic;
using System.Threading.Tasks;
using simpleapi.Models;

namespace simpleapi.Interfaces
{
    public interface IEmployeeInfo
    {
        public Task<EmployeeInfo> SaveEmployeeInfo(EmployeeInfo employee);
        public Task<EmployeeInfo> UpdateEmployeeInfo(EmployeeInfo employee);
        public Task<EmployeeInfo> GetEmployeeById(int id);
        public Task<IEnumerable<EmployeeInfo>> GetAllEmployee();
        public Task<EmployeeInfo> DeleteEmployee(EmployeeInfo employee);

    }
}