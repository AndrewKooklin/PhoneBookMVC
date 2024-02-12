using PhoneBookMVC.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookMVC.Domain
{
    public class DataManager
    {
        public IPhoneBookRecordsRepository PhoneBookRecords { get; set; }

        public DataManager(IPhoneBookRecordsRepository phoneBookRecords)
        {
            PhoneBookRecords = phoneBookRecords;
        }
    }
}
