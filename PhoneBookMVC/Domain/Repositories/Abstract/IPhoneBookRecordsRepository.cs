using PhoneBookMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookMVC.Domain.Repositories.Abstract
{
    public interface IPhoneBookRecordsRepository
    {
        IQueryable<PhoneBookRecord> GetPhoneBookRecords();
        PhoneBookRecord GetPhoneBookRecordById(int id);
    }
}
