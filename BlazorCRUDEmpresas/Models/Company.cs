using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BlazorCRUDEmpresas.Models
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(13)]
        public string Fone { get; set; }
        public void GeneretNewId()
        {
            Id = Guid.NewGuid();
        }



    }
}
