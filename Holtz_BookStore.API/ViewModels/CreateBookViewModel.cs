using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Holtz_BookStore.API.ViewModels
{
    public class CreateBookViewModel
    {
        public CreateBookViewModel()
        {
        }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Book Name: ")]
        public string Name { get; set; }


        
        [Required(ErrorMessage = "*")]
        [Display(Name = "Book ISBN: ")]
        public string ISBN { get; set; }


        [Required(ErrorMessage = "*")]
        [Display(Name = "Start Date ")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }



        [Required(ErrorMessage = "*")]
        [Display(Name = "Category: ")]
        public int CategoryId { get; set; }
        public SelectList CategoryOptions { get; set; }
    }
}