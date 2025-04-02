using DSV.Models;
namespace DSV.Repository
{
    public class CalenderRepository : ICalenderRepository
    {
        List<Room> _rooms = new();
        List<Booking> _bookings = new();
        List<Array> _calenders = new();

        string[] mon = new string[9];
        string[] tue = new string[9];
        string[] wed = new string[9];
        string[] thur = new string[9];
        string[] fri = new string[9];
        string[] time = new string[] { "tid", "08:00-09:00", "09:00-10:00", "10:00-11:00", "11:00-12:00", "12:00-13:00", "13:00-14:00", "14:00-15:00", "15:00-16:00" };


        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }
        public List<Room> GetAll()
            { return _rooms; }

        public string[] GetMon() 
            {
            mon[0] = "Monday";
            return mon; 
            }
        public string[] GetTue() 
            {
            tue[0] = "Tuesday";
            return tue; 
            }
        public string[] GetWed() 
            {
            wed[0] = "Wednesday";
            return wed; 
            }
        public string[] GetThur() 
            {
            thur[0] = "Thursday";
            return thur; 
            }
        public string[] GetFri() 
            {
            fri[0] = "Friday";
            return fri; 
            }
        public string[] GetTime() 
            {
            return time; 
            }
        

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
