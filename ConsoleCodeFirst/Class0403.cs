using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeFirst
{
    class Class0403
    {
    }
    public class Town {

        public Town() {
            //Streets = new HashSet< Street >();
        }

        //[ForeignKey("Supplier")]

        public int TownID { get; set; }
        public string TownName { get; set; }

        //public virtual Supplier Supplier { get; set; }
        //public virtual ICollection< Street> Streets { get; set; }
    }
    //before i use //[ForeignKey("Supplier")]
    //    public int TownID { get; set; }
    public class Street
    {
        public Street() {
            //this.Town = new HashSet<Town>();
        }
        //[ForeignKey("Supplier")]
        public int StreetID { get; set; }

        public string StreetName { get; set; }
        //public virtual Supplier Supplier { get; set; }
        //public virtual ICollection<Town> Town { get; set; }
    }
    public class Adress
    {

        [Key, Column(Order = 0)]
        public int TownID { get; set; }
        [Key, Column(Order = 1)]
        public int StreetID { get; set; }

        //[Key]
        ////[ForeignKey("Town")]
        //public int TownID { get; set; }
        ////[ForeignKey("Street")]
        ////[Key]
        //public int StreetID { get; set; }
        public virtual  Town  Town { get; set; }
        public virtual  Street  Street { get; set; }
        //public int AdressID { get; set; }
        public int NumberAdress { get; set; }

        //public int StreetID { get; set; }
    }
    public class Supplier
    {
        public Supplier() {

        }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        //public string Phone { get; set; }
        //public string Email { get; set; }
        public Nullable<int> TownID { get; set; }
        public Nullable<int> StreetID { get; set; }
        //public Nullable<int> AdressNumber { get; set; }
        public virtual Town Town { get; set; }
        public virtual Street Street { get; set; }
        public virtual Adress Adress { get; set; }
    }

    //Columns of table Town: TownID(primary key), NameTown</p>
    //<p>Columns of table Street: TownID,StreetID(composite primary key),NameStreet</p>
    //<p>Columns of table Adress: TownID,StreetID,NumberAdress(<wbr>all of these columns are composite primary key)</p>
    //<p>Columns of table Supplier: SupplierID,NameSupplier,<wbr>TownID,StreetID,NumberAdress,NumberOfPhone, Email</p>
}
