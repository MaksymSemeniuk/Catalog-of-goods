using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Repository.Dto.CategoryDto
{
    public class CategoryCreateDto
    {
        [Required(ErrorMessage = "Введіть категорію")]
        [StringLength(3, ErrorMessage = "Must be between 5 and 16 characters", MinimumLength = 1)]

        public string? CategoryNumber { get; set; }
        [Required]
        public string? CategoryName { get; set; }
    }
}
