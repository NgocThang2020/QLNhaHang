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
    public class InvoiceBUS : IInvoiceBUS
    {
        private readonly IInvoiceDAO _dao;

        public InvoiceBUS(IInvoiceDAO dao)
        {
            _dao = dao;
        }

        public List<InvoiceDTO> GetAll()
        {
            return _dao.GetAll();
        }

        public void Commit(List<InvoiceDTO> invoices, List<int> deletedIds)
        {
            foreach (var id in deletedIds)
            {
                _dao.Delete(id);
            }

            foreach (var inv in invoices)
            {
                if (inv.InvoiceId == 0)
                    _dao.Insert(inv);
                else
                    _dao.Update(inv);
            }
        }
    }
}
