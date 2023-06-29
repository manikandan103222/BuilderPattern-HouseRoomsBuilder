using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRoomsBuilder.Product
{
    public class House
    {
        List<Room> houseRooms;
        public House(List<Room> houseRooms)
        {
            this.houseRooms = houseRooms;
        }

        public List<Room> getHouseRooms()
        {
            return this.houseRooms;
        }
    }
}
