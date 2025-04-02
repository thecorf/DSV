using DSV.Models;

namespace DSV.Repository
{
    public interface ICalenderRepository
    {
        public void AddRoom(Room room);
        public List<Room> GetAll();
        
        public string[] GetMon();

        public string[] GetTue();


        public string[] GetWed();


        public string[] GetThur();


        public string[] GetFri();


        public string[] GetTime();
       
    }
}
