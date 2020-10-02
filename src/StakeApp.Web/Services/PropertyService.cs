using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StakeApp.Data.DatabaseContexts.ApplicationDbContext;
using StakeApp.Data.Entities;
using StakeApp.Web.Interfaces;
using StakeApp.Web.Models;

namespace StakeApp.Web.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly ApplicationDbContext _dbContext;
        public PropertyService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public  IEnumerable<Property> GetAllProperties()
        {
            return _dbContext.Properties;
            // we need to return a list of properties.
        }
        public async Task AddProperty(PropertyModel model)
        {
            var property = new Property
            {   Id = Guid.NewGuid().ToString(),
                Title = model.Title,
                ImageUrl = model.ImageUrl,
                Price = model.Price,
                Description = model.Description,
                NumberOfRooms = model.NumberOfRooms,
                NumberOfBaths = model.NumberOfBaths,
                NumberOfToilets = model.NumberOfToilets,
                Address = model.Address,
                ContactPhoneNumber = model.ContactPhoneNumber

            };

            await _dbContext.AddAsync(property);
            await _dbContext.SaveChangesAsync();
        }
    }
}