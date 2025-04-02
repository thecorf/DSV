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
        [BindProperty]
        public static string[] Monday { get; set; }
        public static string[] Tuesday { get; set; }
        public static string[] Wednesday { get; set; }
        public static string[] Thursday { get; set; }
        public static string[] Friday { get; set; }
        public static string[] Time { get; set; }
        public static List<Room> rooms 
        { get; set; }
        public CalenderPageModel(CalenderService serviceCalender) 
        {
            Monday = serviceCalender.GetMon();
            Tuesday = serviceCalender.GetTue();
            Wednesday = serviceCalender.GetWed();
            Thursday = serviceCalender.GetThur();
            Friday = serviceCalender.GetFri();
            Time = serviceCalender.GetTime();
            _service = serviceCalender;
            rooms = serviceCalender.GetAll();
        }
        public void OnGet()
        {

        }
    }
}
