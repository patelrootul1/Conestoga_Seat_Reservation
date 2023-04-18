using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment3_SeatReservation
{
    //Creating a class seat and defining name and seatnumber variable
    //using the IComparable to compare name string
    public class Seat: IComparable<Seat>
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string SeatNumber { get; set; }

        //implementing the interface of IComparable
        public int CompareTo(Seat other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
