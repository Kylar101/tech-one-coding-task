
using System.ComponentModel.DataAnnotations;

namespace DollarsToWordConverter.Server.Definitions
{
    public class ConverterRequest
    {
        [Required]
        [Range(0, 999999999999)] // Set max to 999, 999, 999, 999
        public decimal Value { get; set; }
    }
}
