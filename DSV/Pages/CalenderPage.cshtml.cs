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
        public static string[] Time = ["09:00 am","10:00 am", "11:00 am", "12:00 pm", "01:00 pm"];
        [BindProperty]
        public static List<Room> Rooms { get; set; }
        public Booking Booking { get; set; }
        public int j { get; set; }
        public int i { get; set; }

        public CalenderPageModel(CalenderService serviceCalender) 
        {
            Booking = new Booking();
            _service = serviceCalender;
            Rooms = serviceCalender.GetAll();

        }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {

            Debug.WriteLine("test " + Booking.Title);
            Debug.WriteLine("test " + j);
            Debug.WriteLine("test " + i);

            _service.Edit(j, i, Booking);
            return RedirectToPage("/CalenderPage");

        }



    }
}
