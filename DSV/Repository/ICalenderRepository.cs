using DSV.Models;

namespace DSV.Repository
{
    public interface ICalenderRepository
    {
        public void AddRoom(Room room);
        public List<Room> GetAll();
        public void Edit(int j, int i, Booking booking);
        public void AddFilteredRoom(Room room);
        public List<Room> GetAllFilteredRooms();
     }
}
