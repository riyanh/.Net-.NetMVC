using System.ComponentModel.DataAnnotations;


namespace CodeIDBootcampeMVC.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        public string? Pob { get; set; }
    }
}
