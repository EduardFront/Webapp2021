using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webapp2021.Models
{
    public class Person:ModelParrent
    {
        [Display(Name = "Имя")]
        public override string Name { get => base.Name; set => base.Name = value; }
        public string Sername { get; set; }
        public string Patronymic { get; set; }
        public List<Phone> Phones { get; set; }

    }
}
