namespace DSV.Models
{
    public class Room
    {
        public string RoomName { get; set; }
        public bool Whiteboard { get; set; }
        public bool Projector { get; set; }
        //To see whether the CEO is present
        public bool Clown { get; set; }
        public int Capacity { get; set; }
        public Booking[] Bookings {get; set;}

        public Room(string room, bool whiteboard, bool projector, bool clown, int capacity)
        {
            RoomName = room;
            Whiteboard = whiteboard;
            Projector = projector;
            Clown = clown;
            Capacity = capacity;


            Bookings = new Booking[25];
            for (int i = 0; i < 25; i++)
            {
                Bookings[i] = new(0, " ", " ", " ", 0);
            }
        }

    }
}
