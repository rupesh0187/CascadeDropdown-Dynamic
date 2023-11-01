using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dropdownmvc.Models.cascande
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
       
        public Country Country { get; set; }
    }
}
