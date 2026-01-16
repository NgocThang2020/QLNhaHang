using NhaHangDAL.DAO.Interfaces;
using NhaHangDAL.DTO;
using NhaHangDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangDAL.DAO.Implements
{
    public class InvoiceDAO : IInvoiceDAO
    {
        private readonly NhaHangDBContext _context;

        public InvoiceDAO(NhaHangDBContext context)
        {
            _context = context;
        }

        public List<InvoiceDTO> GetAll()
        {
            return _context.Invoices
                .Select(x => new InvoiceDTO
                {
                    InvoiceId = x.InvoiceId,
                    CreatedDate = x.CreatedDate,
                    TotalMoney = x.TotalMoney,
                    Status = x.Status,
                    TableId = x.TableId,
                    StaffId = x.StaffId,
                    ShiftId = x.ShiftId
                })
                .ToList();
        }

        public void Insert(InvoiceDTO dto)
        {
            var entity = new Invoice
            {
                CreatedDate = dto.CreatedDate,
                TotalMoney = dto.TotalMoney,
                Status = dto.Status,
                TableId = dto.TableId,
                StaffId = dto.StaffId,
                ShiftId = dto.ShiftId
            };

            _context.Invoices.Add(entity);
            _context.SaveChanges();

            dto.InvoiceId = entity.InvoiceId;
        }

        public void Update(InvoiceDTO dto)
        {
            var entity = _context.Invoices.Find(dto.InvoiceId);
            if (entity == null) return;

            entity.CreatedDate = dto.CreatedDate;
            entity.TotalMoney = dto.TotalMoney;
            entity.Status = dto.Status;
            entity.TableId = dto.TableId;
            entity.StaffId = dto.StaffId;
            entity.ShiftId = dto.ShiftId;

            _context.SaveChanges();
        }

        public void Delete(int invoiceId)
        {
            var entity = _context.Invoices.Find(invoiceId);
            if (entity == null) return;

            _context.Invoices.Remove(entity);
            _context.SaveChanges();
        }
    }
}
