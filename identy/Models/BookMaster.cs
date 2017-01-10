using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace identy.Models
{
    public class BookMaster
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required At least one unassgined group is Required.")]
        public string strBookTypeId { get; set; }
    }
}