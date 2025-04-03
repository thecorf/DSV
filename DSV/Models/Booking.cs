namespace DSV.Models
{
    public class Booking
    {
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TimeInterval { get; set; }
        public int Day { get; set; }
        
        public Booking() { }

        public Booking(int userID, string title, string description, string timeInterval, int day)
        {
            UserID = userID;
            Title = title;
            Description = description;
            TimeInterval = timeInterval;
            Day = day;
        }
    }
}
