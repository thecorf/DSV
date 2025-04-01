using DSV.Models;
namespace DSV.Repository
{
    public class CalenderRepository : ICalenderRepository
    {
        List<Room> _room = new();

        public void AddRoom(Room room)
        {
            _room.Add(room);
        }
        List<Booking> _bookings = new();
        public CalenderRepository()
        {
            AddRoom(new Room("rum1", true, true, false, 2, _bookings));
            AddRoom(new Room("rum2", true, false, false, 10, _bookings));
            AddRoom(new Room("rum3", true, true, false, 13, _bookings));
            AddRoom(new Room("rum4", true, false, false, 25, _bookings));
            AddRoom(new Room("rum5", false, false, true, 99, _bookings));
        }
    }
}
