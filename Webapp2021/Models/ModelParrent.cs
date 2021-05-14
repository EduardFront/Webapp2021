using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webapp2021.Models
{
    
    public class ModelParrent
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}
