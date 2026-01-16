using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DAO.Interfaces
{
    public interface IInvoiceDAO
    {
        List<InvoiceDTO> GetAll();
        void Insert(InvoiceDTO invoice);
        void Update(InvoiceDTO invoice);
        void Delete(int invoiceId);
    }
}
