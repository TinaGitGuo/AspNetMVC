using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    
        public partial class Contact1
        {
        [Key]
        public string Accountno { get; set; }
            public string Company { get; set; }
            public string Contact { get; set; }
            //... other fields
            public string Recid { get; set; }

            public virtual Contact2 Contact2s { get; set; }
        }


    
}
