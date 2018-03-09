using Mycobank.Services.Models;
using System.Threading.Tasks;

namespace Mycobank.Services
{
    public interface ISearch
    {
        Task<Results> Perform();
    }
}
