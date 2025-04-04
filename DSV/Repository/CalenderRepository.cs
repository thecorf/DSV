using DSV.Models;
namespace DSV.Repository
{
    public class CalenderRepository : ICalenderRepository
    {
        List<Room> _filteredRooms = new();
        List<Room> _rooms = new();
        //Booking[] _bookings = new Booking[25];

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }
        public void AddFilteredRoom(Room room)
        {  
            _filteredRooms.Add(room); 
        }
        public void Edit(int j, int i, Booking booking)
        {
            _rooms[j].Bookings[i] = booking;
        }

        public void Filter(bool whiteboard, bool projector, int capacity)
        {
            _filteredRooms.Clear();
            
            if (whiteboard && projector == false && capacity < 1)
            {
                foreach (Room room in _rooms)
                {
                    if (whiteboard == room.Whiteboard)
                    {
                        AddFilteredRoom(room);
                    }
                }
            }
            else if (whiteboard && projector == true && capacity < 1)
            {
                foreach (Room room in _rooms)
                {
                    if (whiteboard == room.Whiteboard && projector == room.Projector)
                    {
                        AddFilteredRoom(room);
                    }
                }
            }
            else if (whiteboard && projector && capacity >= 1)
            {
                foreach (Room room in _rooms)
                {
                    if (whiteboard == room.Whiteboard && room.Projector == projector && capacity <= room.Capacity)
                    {
                        AddFilteredRoom(room);
                    }
                }
            } 
            else if (!whiteboard && projector && capacity >= 1)
            {
                foreach (Room room in _rooms)
                {
                    if (room.Projector == projector && capacity <= room.Capacity)
                    {
                        AddFilteredRoom(room);
                    }
                }
            } 
            else if (!whiteboard && !projector && capacity >= 1)
            {
                foreach (Room room in _rooms)
                {
                    if (capacity <= room.Capacity)
                    {
                        AddFilteredRoom(room);
                    }
                }
            }
            else if (whiteboard && !projector && capacity >= 1)
            {
                foreach (Room room in _rooms)
                {
                    if (whiteboard == room.Whiteboard && capacity <= room.Capacity)
                    {
                        AddFilteredRoom(room);
                    }
                }
            }
            else if (!whiteboard && projector && capacity < 1)
            {
                foreach (Room room in _rooms)
                {
                    if (projector == room.Projector)
                    {
                        AddFilteredRoom(room);
                    }
                }
            }
            
        }

        public List<Room> GetAll()
        {
            return _rooms; 
        }
        public List<Room> GetAllFilteredRooms()
        {
            return _filteredRooms; 
        }

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
