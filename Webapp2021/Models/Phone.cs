using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webapp2021.Models
{
    [Display(Name = "Testing")]
    public class Phone
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Display(Name = "Модель")]
        public string Model { get; set; }
        [Display(Name = "Описание товара")]
        public string Description { get; set; }
        [Display(Name = "Создана")]
        public DateTime Created { get; set; }
        //public DateTime Updated { get; set; }
        [Display(Name = "Цена")]
        public string Price { get; set; }
        [Display(Name = "В наличии")]
        public bool IsActive { get; set; }
 

    }
}
