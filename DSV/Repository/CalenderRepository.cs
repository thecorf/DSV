using DSV.Models;
namespace DSV.Repository
{
    public class CalenderRepository : ICalenderRepository
    {
        List<Room> _rooms = new();
        List<Booking> _bookings = new();
        List<Array> _calenders = new();

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }
        public List<Room> GetAll()
            { return _rooms; }

        public List<Array> GetCalender() 
            { return _calenders; }

        public CalenderRepository()
        {
            _calenders.Add (new string[] { "tid", "08:00-09:00", "09:00-10:00", "10:00-11:00", "11:00-12:00", "12:00-13:00", "13:00-14:00", "14:00-15:00", "15:00-16:00" });
            string[] mon = new string[9];
            string[] tue = new string[9];
            string[] wed = new string[9];
            string[] thur = new string[9];
            string[] fri = new string[9];
            mon[0] = "monday";
            tue[0] = "tuesday";
            wed[0] = "wednesday";
            thur[0] = "thursday";
            fri[0] = "friday";

            AddRoom(new Room("rum1", true, true, false, 2, _bookings));
            AddRoom(new Room("rum2", true, false, false, 10, _bookings));
            AddRoom(new Room("rum3", true, true, false, 13, _bookings));
            AddRoom(new Room("rum4", true, false, false, 25, _bookings));
            AddRoom(new Room("rum5", false, false, true, 99, _bookings));

        }

    }
}
