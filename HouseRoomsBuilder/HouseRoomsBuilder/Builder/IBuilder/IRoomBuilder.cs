using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRoomsBuilder
{
    public interface IRoomBuilder<T>
    {
        T setRoomType(RoomType roomType);
        T setCeilingHeight(int ceilingHeight);
        T setFloorNumber(int floorNumber);
        T setWallColor(WallColor wallColor);
        T setNumberOfWindows(int numberOfWindows);
    }
}
