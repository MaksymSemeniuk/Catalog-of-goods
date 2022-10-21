using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Repository.Dto.TypegDto
{
    public class TypegCreateDto
    {
        [Required(ErrorMessage = "Введіть назву")]
        [StringLength(16, ErrorMessage = "Must be between 5 and 16 characters", MinimumLength = 5)]
        [RegularExpression("[a-zA-Z]", ErrorMessage = "Невірні символи")]
        public string? DayName { get; set; }
    }
}
