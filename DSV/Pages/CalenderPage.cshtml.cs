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
        public static List<Room> rooms 
        { get; set; }
        public CalenderPageModel(CalenderService serviceCalender) 
        {
            
            _service = serviceCalender;
            rooms = serviceCalender.GetAll();
        }
        public void OnGet()
        {

        }
    }
}
