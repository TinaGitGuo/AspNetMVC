﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetCore
{
    
        public  class Contact1
        {
        public Contact1()
        {
           
        }
        [Display(Name = "BirthDaterrr")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? Birth_Date { get; set; }
        public string Accountno { get; set; }
        public string Company { get; set; }
        public string Contact { get; set; }
        //... other fields
        public string Recid { get; set; }

        public virtual   Contact4  Contact4s { get; set; }
        }  
}
