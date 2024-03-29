﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookMVC.Domain.Entities
{
    public class EntityBase
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Display(Name = "Фамилия")]
        public virtual string LastName { get; set; }

        [Display(Name = "Имя")]
        public virtual string FirstName { get; set; }

        [Display(Name = "Отчество")]
        public virtual string FathersName { get; set; }

        [Display(Name = "Телефон")]
        public virtual string PhoneNumber { get; set; }

        [Display(Name = "Адрес")]
        public virtual string Address { get; set; }

        private string description;

        [Display(Name = "Описание")]
        public virtual string Description 
        {
            get 
            { 
                return description = $"{Id} {LastName} {FirstName} {FathersName}";
            }
            set
            {
                description = value;
            }
        } 
    }
}
