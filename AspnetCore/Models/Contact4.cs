using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetCore
{
    public  class Contact4
    {
        //public Contact2()
        //{
        //    Contact1s = new Contact1();
        //}
        //[Key]
        public string Accountno { get; set; }
        public DateTime? Callbackon { get; set; }
        ///... other fields

        public string Recid { get; set; }

        public virtual Contact1 Contact1s { get; set; }
    }

}
