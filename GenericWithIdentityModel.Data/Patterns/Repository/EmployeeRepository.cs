using GenericWithIdentityModel.Data.Model;
using GenericWithIdentityModel.Data.Patterns;
using GenericWithIdentityModel.Data.Patterns.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericWithIdentityModel.Data.Patterns.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Employee entity)
        {
            _context.Employees.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _context.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (data != null)
            {
                _context.Employees.Remove(data);
                _context.SaveChanges();
            }
        }

        public async Task<IList<Employee>> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _context.Employees.Where(x => x.Id == id).FirstOrDefaultAsync();           
        }

        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
