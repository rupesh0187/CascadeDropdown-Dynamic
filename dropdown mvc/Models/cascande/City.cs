using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;

namespace dropdownmvc.Models.cascande
{
    public class City
    {
        
        public int Id { get; set; }
        public string? Name { get; set; }
       
        public State State { get; set; }
    }
}
