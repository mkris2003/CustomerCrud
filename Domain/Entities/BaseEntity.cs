using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class BaseEntity
    {
        public BaseEntity()
        {
            CreateAt = DateTime.UtcNow;
            LastUpdated = DateTime.UtcNow;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
    