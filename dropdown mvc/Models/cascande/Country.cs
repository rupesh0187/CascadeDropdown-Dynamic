using System.ComponentModel.DataAnnotations;

namespace dropdownmvc.Models.cascande
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
