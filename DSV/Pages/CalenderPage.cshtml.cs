using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DSV.Models;
using DSV.Service;
using DSV.Repository;
using System.Diagnostics;

namespace DSV.Pages
{
    public class CalenderPageModel : PageModel
    {
        private CalenderService _service;
        [BindProperty]
        public static List<Room> Rooms { get; set; }
        public static string[] Time = ["09:00 am","10:00 am", "11:00 am", "12:00 pm", "01:00 pm"];

        public CalenderPageModel(CalenderService serviceCalender) 
        {
            _service = serviceCalender;
            Rooms = serviceCalender.GetAll();
            Rooms[1].Bookings[6] = new Booking(2150, "Death", "We are dead", "no", 3);
            Rooms[0].Bookings[3] = new Booking(2150, "Fish", "We are fish", "no", 3);
            Rooms[0].Bookings[5] = new Booking(2150, "Goat", "We are goated", "no", 3);
            Rooms[0].Bookings[23] = new Booking(2150, "Rest", "We are resting", "no", 3);


            //Debug.WriteLine(Rooms[0].RoomName);
            //Debug.WriteLine(Rooms[1].RoomName);
            //Debug.WriteLine(Rooms[2].RoomName);
            //Debug.WriteLine(Rooms[3].RoomName);
            //Debug.WriteLine(Rooms[4].RoomName);
        }
        public void OnGet()
        {

        }
    }
}
