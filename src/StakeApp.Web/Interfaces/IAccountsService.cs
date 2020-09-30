using System.Threading.Tasks;
using StakeApp.Data.Entities;
using StakeApp.Web.Models;

namespace StakeApp.Web.Interfaces
{
    public interface IAccountsService
    {
         Task<ApplicationUser> CreateUserAsync(RegisterModel model);
    }
}