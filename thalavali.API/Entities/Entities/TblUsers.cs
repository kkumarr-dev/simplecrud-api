using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace thalavali.API.Entities
{
    [Table("TblUsers")]
    public class TblUsers
    {
        [Key]
        public int Userid { get; set; }
        public string username { get; set; }
        public string phonenumber { get; set; }
    }
}
