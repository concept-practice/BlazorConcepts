using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorConcepts.Pages.Forms
{
    public class Airplane
    {
        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Model { get; set; }

        [Required] 
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
