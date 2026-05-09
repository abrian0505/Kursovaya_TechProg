using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_TechProg.Models
{
    internal class Room
    {
        private int _roomId;
        private int _hotelId;
        private int _roomNumber;
        private string _type;
        private int _capacity;
        private int _price;
        private List<RoomBenefit> _benefits;
    }
}
