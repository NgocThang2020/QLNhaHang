using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DAO.Interfaces
{
    public interface IInvoiceDetailDAO
    {
        List<InvoiceDetailDTO> GetByInvoiceId(int invoiceId);
    }
}
