using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DSV.Models;
using DSV.Service;
using DSV.Repository;

namespace DSV.Pages
{
    public class CalenderPageModel : PageModel
    {
        private CalenderService _service;
        public static string[] Time = ["09:00 am","10:00 am", "11:00 am", "12:00 pm", "01:00 pm"];
        [BindProperty]
        public bool Projector { get; set; } = false;

        [BindProperty]
        public bool Whiteboard { get; set; } = false;
        [BindProperty]
        public int Capacity { get; set; } = 0;
        [BindProperty]
        public List<Room> Rooms { get; set; }
        [BindProperty]
        public List <Room> FilteredRooms { get; set; }
        [BindProperty]
        public Booking Booking { get; set; }

       
        public CalenderPageModel(CalenderService serviceCalender) 
        {
            Booking = new Booking();
            _service = serviceCalender;
            Rooms = serviceCalender.GetAll();
            FilteredRooms = serviceCalender.GetAllFilteredRooms();
           
        }
        public void OnGet()
        {

        }

        public void OnPost()
        { 

        }
        public void OnPostFilter()
        {

            Debug.WriteLine("test " + Projector);
            _service.Filter(Whiteboard, Projector, Capacity);
            FilteredRooms = _service.GetAllFilteredRooms();
            Rooms = _service.GetAll();


            //return null;
        }

        public void OnPostBooking(int j, int i)
        {
            Debug.WriteLine("test a " + Booking.Title);
            Debug.WriteLine("test a " + j);
            Debug.WriteLine("test a " + i);
            Rooms = _service.GetAll();


            _service.Edit(j, i, Booking);


        }


    }
}
