using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST_rebase.DAO
{
    internal class goods
    {
        [Key]
        public int goodsId {  get; set; }
        public string goodsName {  get; set; }
        public DateOnly entryDate {  get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public string unit { get; set; }
        public string suppiler { get; set; }
        public string type { get; set; }
    }
}
