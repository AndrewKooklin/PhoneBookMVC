using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookMVC.Domain.Entities
{
    public class PhoneBookRecord : EntityBase
    {

        [Display(Name = "Фамилия")]
        public override string LastName { get; set; }

        [Display(Name = "Имя")]
        public override string FirstName { get; set; }

        [Display(Name = "Отчество")]
        public override string FathersName { get; set; }

        [Display(Name = "Телефон")]
        public override string PhoneNumber { get; set; }

        [Display(Name = "Адрес")]
        public override string Address { get; set; }

        [Display(Name = "Описание")]
        public override string Description { get; set; }
    }
}
