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
        public List<Room> GetAll()
        { return _calenderRepository.GetAll(); }


    }
}
