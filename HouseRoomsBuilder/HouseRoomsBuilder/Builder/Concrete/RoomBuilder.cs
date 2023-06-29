using HouseRoomsBuilder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRoomsBuilder
{
    public class RoomBuilder : IRoomBuilder<RoomBuilder>
    {
        private RoomType roomType;
        private int ceilingHeight;
        private int floorNumber;
        private WallColor wallColor;
        private int numberOfWindows;
        private int numberOfDoors;
        private bool isDouble;
        private RoomListBuilder roomListBuilder;

        public RoomBuilder() { }

        public RoomBuilder(RoomListBuilder roomListBuilder)
        {
            this.roomListBuilder = roomListBuilder;
        }

        public RoomBuilder setRoomType(RoomType roomType)
        {
            this.roomType = roomType;
            return this;
        }

        public RoomBuilder setCeilingHeight(int ceilingHeight)
        {
            this.ceilingHeight = ceilingHeight;
            return this;
        }

        public RoomBuilder setFloorNumber(int floorNumber)
        {
            this.floorNumber = floorNumber;
            return this;
        }

        public RoomBuilder setWallColor(WallColor wallColor) 
        {
            this.wallColor = wallColor;
            return this;
        }

        public RoomBuilder setNumberOfWindows(int numberOfWindows)
        {
            this.numberOfWindows = numberOfWindows;
            return this;
        }

        public RoomBuilder setNumberOfDoors(int numberOfDoors)
        {
            this.numberOfDoors = numberOfDoors;
            return this;
        }

        public RoomBuilder setIsDouble(bool isDouble)
        {
            this.isDouble = isDouble;
            return this;
        }

        public Room createRoom()
        {
            return new Room(roomType, ceilingHeight, floorNumber, wallColor, numberOfWindows, numberOfDoors, isDouble);
        }

        public RoomListBuilder addRoomToList()
        {
            Room room = createRoom();
            this.roomListBuilder.addRoom(room);
            return this.roomListBuilder;
        }

    }
}
