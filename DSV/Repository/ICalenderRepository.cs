using DSV.Models;

namespace DSV.Repository
{
    public interface ICalenderRepository
    {
        public void AddRoom(Room room);
        public List<Room> GetAll();
        public List<Array> GetCalender();
    }
}
