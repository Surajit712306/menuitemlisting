using System.ComponentModel.DataAnnotations;

namespace MenuItemListing.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name="Free Delivery")]
        public bool FreeDelivery { get; set; }
        [Required]
        public double Price { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfLaunch { get; set; }
        public bool Active { get; set; }

    }
}
