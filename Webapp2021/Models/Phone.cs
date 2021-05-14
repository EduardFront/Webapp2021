using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webapp2021.Models
{
    [Display(Name = "Testing")]
    public class Phone:ModelParrent
    {

        [Display(Name = "Название")]
        public override string Name { get => base.Name; set => base.Name = value; }
        
        [Display(Name = "Модель")]
        public string Model { get; set; }
        [Display(Name = "Описание товара")]
        public string Description { get; set; }
        [Display(Name = "Создана")]
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public virtual Person Creator { get; set; }
        [Display(Name = "Цена")]
        public string Price { get; set; }
        [Display(Name = "В наличии")]
        public bool IsActive { get; set; }
 

    }
}
