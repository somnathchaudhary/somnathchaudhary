using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DbCode.Models
{
    [Table("Person")]
    public class Person
    {   [Key]
        public int PId { get; set; }
        public string PName { get; set; }
    }
}
