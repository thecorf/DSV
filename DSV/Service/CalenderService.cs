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

        public string[] GetMon()
        {
            return _calenderRepository.GetMon();
        }
        public string[] GetTue()
        {
            return _calenderRepository.GetTue();
        }
        public string[] GetWed()
        {
            return _calenderRepository.GetWed();
        }
        public string[] GetThur()
        {
            return _calenderRepository.GetThur();
        }
        public string[] GetFri()
        {
            return _calenderRepository.GetFri();
        }
        public string[] GetTime()
        {
            return _calenderRepository.GetTime();
        }
    }
}
