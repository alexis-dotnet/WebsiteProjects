using System.Collections.Generic;
using System.Threading.Tasks;
using Pagos.Auto.Entities;

namespace Pagos.Auto.Data
{
    public interface IMainData
    {
        Task<List<CarPayment>> GetAllCarPaymentsAsync();
    }
}
