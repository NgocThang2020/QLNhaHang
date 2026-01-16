using NhaHangDAL.DAO.Interfaces;
using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DAO.Implements
{
    public class InvoiceDetailDAO : IInvoiceDetailDAO
    {
        private readonly NhaHangDBContext _context;

        public InvoiceDetailDAO(NhaHangDBContext context)
        {
            _context = context;
        }

        public List<InvoiceDetailDTO> GetByInvoiceId(int invoiceId)
        {
            return _context.InvoiceDetails
                .Where(x => x.InvoiceId == invoiceId)
                .Select(x => new InvoiceDetailDTO
                {
                    InvoiceId = x.InvoiceId,
                    FoodId = x.FoodId,
                    Quantity = x.Quantity,
                    UnitPrice = x.UnitPrice
                })
                .ToList();
        }
    }
}
