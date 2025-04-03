using System;
using System.Globalization;
using DSV.Models;
using DSV.Repository;
namespace DSV.Service
{
    public class CalenderService
    {
        private ICalenderRepository _calenderRepository;

        public CalenderService(ICalenderRepository calenderRepository)
        {
            _calenderRepository = calenderRepository;
        }

        public void AddRoom(Room room)
        {
            _calenderRepository.AddRoom(room);
        }
        public void AddFilteredRoom(Room room)
        {
            _calenderRepository.AddFilteredRoom(room);
        }
        public List<Room> GetAll()
        { 
            return _calenderRepository.GetAll(); 
        }
        public List<Room> GetAllFilteredRooms()
        {
            return _calenderRepository.GetAllFilteredRooms();
        }

        public void Edit(int j, int i, Booking booking)
        {
            _calenderRepository.Edit(j, i, booking);
        }

    }
}
