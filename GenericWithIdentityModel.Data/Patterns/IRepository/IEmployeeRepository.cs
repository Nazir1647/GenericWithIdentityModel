using GenericWithIdentityModel.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericWithIdentityModel.Data.Patterns.IRepository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {

    }
}
