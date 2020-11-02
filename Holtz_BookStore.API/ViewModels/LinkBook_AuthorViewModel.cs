using System.ComponentModel.DataAnnotations;

namespace Holtz_BookStore.ViewModels
{
    public class LinkBook_AuthorViewModel
    {
        [Required(ErrorMessage = "*")]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "*")]
        public int BookId { get; set; }
    }
}