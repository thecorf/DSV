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
        public List<Array> calenders
        {  get; set; }
        public static List<Room> rooms 
        { get; set; }
        public CalenderPageModel(CalenderService serviceCalender) 
        { 
            calenders = serviceCalender.GetCalender();
            _service = serviceCalender;
            rooms = serviceCalender.GetAll();
        }
        public void OnGet()
        {

        }
    }
}
