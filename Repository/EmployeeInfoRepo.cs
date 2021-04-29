using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using simpleapi.Datas;
using simpleapi.Interfaces;
using simpleapi.Models;

namespace simpleapi.Repository
{
    public class EmployeeInfoRepo: IEmployeeInfo
    {
        private readonly TestContext _context;

        public EmployeeInfoRepo(TestContext context)
        {
            _context = context;
        }

        public async Task<EmployeeInfo> SaveEmployeeInfo(EmployeeInfo employee)
        {
            EntityEntry<EmployeeInfo>  data= await _context.EmployeeInfos.AddAsync(employee);
            await _context.SaveChangesAsync();
            return data.Entity;
        }

        public async Task<EmployeeInfo> UpdateEmployeeInfo(EmployeeInfo employee)
        {
            EntityEntry<EmployeeInfo>  data=  _context.EmployeeInfos.Update(employee);
            await _context.SaveChangesAsync();
            return data.Entity;
        }

        public async Task<EmployeeInfo> GetEmployeeById(int id)
        {
            return await _context.EmployeeInfos.FirstOrDefaultAsync(emp => emp.Id == id);
        }

        public async Task<EmployeeInfo> DeleteEmployee(EmployeeInfo employee)
        {
            EntityEntry<EmployeeInfo> data =
                _context.EmployeeInfos.Remove(employee);

            await this._context.SaveChangesAsync();

            return data.Entity;
        }

        public async Task<IEnumerable<EmployeeInfo>> GetAllEmployee()
        {
            return await  _context.EmployeeInfos.ToListAsync();
             
        }
    }
}