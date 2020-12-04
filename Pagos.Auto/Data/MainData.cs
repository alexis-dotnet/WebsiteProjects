using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pagos.Auto.Context;
using Pagos.Auto.Entities;

namespace Pagos.Auto.Data
{
    public class MainData : IMainData
    {
        private readonly MainContext _context;

        public MainData(MainContext context)
        {
            _context = context;
        }

        public async Task<List<CarPayment>> GetAllCarPaymentsAsync()
        {
            return await _context.CarPayments.ToListAsync();
        }
    }
}
