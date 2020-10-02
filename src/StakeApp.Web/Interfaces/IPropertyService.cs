using System.Collections.Generic;
using System.Threading.Tasks;
using StakeApp.Data.Entities;
using StakeApp.Web.Models;

namespace StakeApp.Web.Interfaces
{
    public interface IPropertyService
    {
        Task AddProperty(PropertyModel model);
        IEnumerable<Property> GetAllProperties();
    }
}