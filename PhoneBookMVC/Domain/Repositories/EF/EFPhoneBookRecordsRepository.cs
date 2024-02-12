using PhoneBookMVC.Domain.Entities;
using PhoneBookMVC.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookMVC.Domain.Repositories.EF
{
    public class EFPhoneBookRecordsRepository : IPhoneBookRecordsRepository
    {
        private readonly AppDBContext _context;

        public EFPhoneBookRecordsRepository(AppDBContext context)
        {
            _context = context;
        }

        public IQueryable<PhoneBookRecord> GetPhoneBookRecords()
        {
            return _context.PhoneBookRecords;
        }
        public PhoneBookRecord GetPhoneBookRecordById(int id)
        {
            return _context.PhoneBookRecords.FirstOrDefault(r => r.Id == id);
        }
    }
}
