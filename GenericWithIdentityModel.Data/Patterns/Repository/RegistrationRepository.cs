using GenericWithIdentityModel.Data.Model;
using GenericWithIdentityModel.Data.Patterns.IRepository;
using GenericWithIdentityModel.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericWithIdentityModel.Data.Patterns.Repository
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly ApplicationDbContext _context;

        public RegistrationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(RegistrationVM entity)
        {
            Registration data = new Registration
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email,
                AddressLine1 = entity.AddressLine1,
                AddressLine2 = entity.AddressLine2,
                Country = entity.Country,
                State = entity.State,
                PostalCode = entity.PostalCode,
                DOB = entity.DOB,
                Gender = entity.Gender,
                CountryCode = entity.CountryCode,
                Phone = entity.Phone,
                Password = entity.Password,
            };
            _context.registrations.Add(data);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<RegistrationVM>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<RegistrationVM> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(RegistrationVM entity)
        {
            throw new NotImplementedException();
        }
    }
}
