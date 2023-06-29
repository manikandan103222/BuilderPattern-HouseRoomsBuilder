using HouseRoomsBuilder.Builder;
using HouseRoomsBuilder.Product;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRoomsBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Normal way of making object with constructor parameters
            //Room room = new Room(RoomType.BedRoom, 132, 2, WallColor.White, 2, 1, true);

            ////With help of builder pattern to making object with constructor parameters

            ////Room - Different combination of fields with one single constructor

            //Room bedroom1 = new RoomBuilder().setRoomType(RoomType.BedRoom).setCeilingHeight(102).setFloorNumber(2).setWallColor(WallColor.White).setNumberOfWindows(2).setNumberOfDoors(1).setIsDouble(true).createRoom();

            //Room bedroom2 = new RoomBuilder().setRoomType(RoomType.BedRoom).setCeilingHeight(100).setNumberOfDoors(1).createRoom();

            ////Kitchen - Different combination of fields with one single constructor

            //Room kitchen1 = new RoomBuilder().setRoomType(RoomType.Kitchen).setCeilingHeight(112).setFloorNumber(2).setWallColor(WallColor.White).setNumberOfWindows(2).setNumberOfDoors(1).createRoom();

            //Room kitchen2 = new RoomBuilder().setRoomType(RoomType.Kitchen).setCeilingHeight(110).createRoom();

            ////GuestRoom - Different combination of fields with one single constructor
            //Room guestroom1 = new RoomBuilder().setRoomType(RoomType.GuestRoom).setCeilingHeight(122).setWallColor(WallColor.White).setNumberOfWindows(1).setNumberOfDoors(1).createRoom();

            //Room guestroom2 = new RoomBuilder().setRoomType(RoomType.GuestRoom).setWallColor(WallColor.Blue).setCeilingHeight(120).createRoom();


            //List<Room> rooms = new List<Room>();

            //rooms.Add(bedroom1);
            //rooms.Add(bedroom2);

            //rooms.Add(kitchen1);
            //rooms.Add(kitchen2);

            //rooms.Add(guestroom1);
            //rooms.Add(guestroom2);

            //List of rooms is being build

            //List<Room> rooms = new RoomListBuilder().addList()
            //    .addRoom(bedroom1).addRoom(bedroom2)
            //    .addRoom(kitchen1).addRoom(kitchen2)
            //    .addRoom(guestroom1).addRoom(guestroom2).buildRooms();

            //whole process of creating the list of rooms would be in a single line of code

            List<Room> rooms = new RoomListBuilder().addList()
                .addRoom().setCeilingHeight(100).setWallColor(WallColor.White).setRoomType(RoomType.BedRoom).setFloorNumber(1).addRoomToList()
                .addRoom().setRoomType(RoomType.Kitchen).setCeilingHeight(200).setWallColor(WallColor.Blue).addRoomToList()
                .addRoom().setCeilingHeight(300).setRoomType(RoomType.GuestRoom).addRoomToList()
                .buildRooms();

            House houseRooms = new House(rooms);

            foreach(var houseRoom in houseRooms.getHouseRooms())
            {
                Console.WriteLine($"Room Type: {houseRoom.roomType}, Ceiling Height: {houseRoom.ceilingHeight}");
            }
            Console.ReadLine();
        }
    }
}
