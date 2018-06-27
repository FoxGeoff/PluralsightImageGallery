using System.ComponentModel.DataAnnotations;

namespace ImageGallery.Model
{
    class ImageForUpdate
    {
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }
    }
}
