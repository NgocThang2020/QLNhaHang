using NhaHangBUL.Interfaces;
using NhaHangDAL.DAO.Interfaces;
using NhaHangDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangBUL.Implements
{
    public class InvoiceDetailBUS : IInvoiceDetailBUS
    {
        private readonly IInvoiceDetailDAO _dao;

        public InvoiceDetailBUS(IInvoiceDetailDAO dao)
        {
            _dao = dao;
        }

        public List<InvoiceDetailDTO> GetByInvoiceId(int invoiceId)
        {
            return _dao.GetByInvoiceId(invoiceId);
        }
    }
}
