using System.Threading.Tasks;
using StakeApp.Web.Models;

namespace StakeApp.Web.Interfaces
{
    public interface IPropertyService
    {
        Task AddProperty(PropertyModel model);
    }
}