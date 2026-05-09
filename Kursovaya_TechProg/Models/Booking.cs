using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_TechProg.Models
{
    internal class Booking
    {
        private int _id;

        private string _userId;
        private string _roomId;

        private DateTime _checkInDate;
        private DateTime _checkOutDate;
        private DateTime _bookingDate;

        private int _guestCount;
        private string _guestFullName;
        private string _guestPassportNumber;
        public Booking(string userId, string roomId, DateTime checkInDate, DateTime checkOutDate, int guestCount)
        {
            _userId = userId;
            _roomId = roomId;
            _checkInDate = checkInDate;
            _checkOutDate = checkOutDate;
            _bookingDate = DateTime.Now;  
            _guestCount = guestCount;
        }
    }
}
