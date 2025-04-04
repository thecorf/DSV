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
        public bool projector { get; set; }   
        
        [BindProperty]
        public bool Fprojector { get; set; }
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
            FilteredRooms = serviceCalender.GetAll();

        }
        public void OnGet()
        {

        }

        public IActionResult OnPost(int i, int j)
        {
            
            Debug.WriteLine("test " + Booking.Title);
            Debug.WriteLine("test " + j);
            Debug.WriteLine("test " + i);

            _service.Edit(j, i, Booking);
            return RedirectToPage("/CalenderPage");

        }
        public IActionResult OnPostFilter()
        {

            Debug.WriteLine("test " + projector);
            return null;
        }


    }
}
