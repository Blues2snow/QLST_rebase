using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST_rebase.DAO
{
    internal class staff
    {
        [Key]
        public int staffId {  get; set; }
        public string staffName { get; set; }
        public DateOnly birthDate { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public double salary { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string position { get; set; }
        public ICollection<account> Accounts { get; set; }
    }
}
