using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangBUL.Interfaces
{
    public interface IInvoiceBUS
    {
        List<InvoiceDTO> GetAll();
        void Commit(List<InvoiceDTO> invoices, List<int> deletedIds);
    }
}
