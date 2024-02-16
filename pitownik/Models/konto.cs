using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pitownik.Models
{
    public class konto
    {
        [Key]
        public int id_konta { get; set; }
        [Required, MinLength(9)]
        public string email { get; set; }
        [Required, MinLength(5)]
        public string haslo { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }

    }
}
