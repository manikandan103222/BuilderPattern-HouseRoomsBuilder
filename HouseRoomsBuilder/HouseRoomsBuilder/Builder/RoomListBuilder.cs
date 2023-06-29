using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRoomsBuilder.Builder
{
    public class RoomListBuilder
    {
        private List<Room> _rooms;

        public RoomListBuilder addList()
        {
            this._rooms = new List<Room>();
            return this;
        }

        public RoomListBuilder addRoom(Room room)
        {
            this._rooms.Add(room);
            return this;
        }

        public RoomBuilder addRoom()
        {
            return new RoomBuilder(this);
        }

        public List<Room> buildRooms()
        {
            return this._rooms;
        }
    }
}
