using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public partial class Contact2
    {
        [Key]
        public string Accountno { get; set; }
        public DateTime? Callbackon { get; set; }
        ///... other fields

        public string Recid { get; set; }

        public virtual Contact1 Contact1 { get; set; }
    }

}
