using System;

namespace Pagos.Auto.Entities
{
    public class CarPayment
    {
        public int Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string FileName { get; set; }
        public string Comment { get; set; }
    }
}
