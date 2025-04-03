using DSV.Models;
namespace DSV.Repository
{
    public class CalenderRepository : ICalenderRepository
    {
        List<Room> _rooms = new();
        //Booking[] _bookings = new Booking[25];

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public void Edit(int j, int i, Booking booking)
        {
            _rooms[j].Bookings[i] = booking;
        }


        public List<Room> GetAll()
            { return _rooms; }

        public CalenderRepository()
        {

            AddRoom(new Room("Rum 1", true, true, false, 2));
            AddRoom(new Room("Rum 2", true, false, false, 10));
            AddRoom(new Room("Rum 3", true, true, false, 13));
            AddRoom(new Room("Rum 4", true, false, false, 25));
            AddRoom(new Room("Rum 5", false, false, true, 99));
        }

    }
}
