using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRoomsBuilder
{
    public class Room
    {
        public RoomType roomType;
        public int ceilingHeight;
        private int floorNumber;
        private WallColor wallColor;
        private int numberOfWindows;
        private int numberOfDoors;
        private bool isDouble;

        public Room(RoomType roomType, int ceilingHeight, int floorNumber, WallColor wallColor, int numberOfWindows, int numberOfDoors, bool isDouble)
        {
            this.roomType = roomType;
            this.ceilingHeight = ceilingHeight;
            this.floorNumber = floorNumber;
            this.wallColor = wallColor;
            this.numberOfWindows = numberOfWindows;
            this.numberOfDoors = numberOfDoors;
            this.isDouble = isDouble;
        }
    }
}
