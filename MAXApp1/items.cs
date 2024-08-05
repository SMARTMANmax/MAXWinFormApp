using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;
using System.Xml.Linq;

namespace MAXApp1
{
    //internal class itemsview
    public class itemsview
    {
        //public int Id { get; set; }
        public String Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int MarketValue { get; set; }
        public int Quantity { get; set; }
        public String Type { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
