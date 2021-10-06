using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryCodeAPI.Model
{
    public class User
    {
        [Key]
        public int userid { get; set; }
        [Column(TypeName= "nvarchar(100)")]
        public string username { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string email { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string password { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string passkey { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string contact { get; set; }
        public DateTime TDT { get; set; }
    }
}
