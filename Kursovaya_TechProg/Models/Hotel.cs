using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_TechProg.Models
{
    internal class Hotel
    {
        private int _hotelID;
        private string _name;
        private string _address;
        private string _city;
        private string _country;
        private int _stars;
        private string _description;
        private List<HotelBenefit> _benefits;
        private List<Room> _rooms;
        public Hotel(string name, string address, string city, string country, int stars, string description)
        {
            _name = name;
            _address = address;
            _city = city;
            _country = country;
            _stars = stars;
            _description = description;
            _benefits = new List<HotelBenefit>();
            _rooms = new List<Room>();
        }


    }
}
