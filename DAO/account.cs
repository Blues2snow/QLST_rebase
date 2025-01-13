using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST_rebase.DAO
{
    internal class account
    {
        [Key]
        public int accountId {  get; set; }
        public string _account {  get; set; }
        public string _password { get; set; }
        [ForeignKey("staffId_FK")]
        public int staffId { get; set; }
        public staff staff { get; set; }
    }
}
