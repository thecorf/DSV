using DSV.Models;
namespace DSV.Repository
{
    public class CalenderRepository : ICalenderRepository
    {
        List<Room> _rooms = new();
        Booking[] _bookings = new Booking[25];


        List<Array> _calenders = new();

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }
        public List<Room> GetAll()
            { return _rooms; }

        public CalenderRepository()
        {
            for (int i = 0; i < 25; i++) 
            {
                _bookings[i] = new(0," "," "," ",0);
            }

            AddRoom(new Room("rum1", true, true, false, 2, _bookings));
            AddRoom(new Room("rum2", true, false, false, 10, _bookings));
            AddRoom(new Room("rum3", true, true, false, 13, _bookings));
            AddRoom(new Room("rum4", true, false, false, 25, _bookings));
            AddRoom(new Room("rum5", false, false, true, 99, _bookings));

        }

    }
}
