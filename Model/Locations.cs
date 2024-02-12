using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CManagement.Model
{
    internal class Locations
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public Locations()
        {

        }
        public Locations(int locationID, string locationName, string address)
        {
            LocationID = locationID;
            LocationName = locationName;
            Address = address;
        }
    }
}
