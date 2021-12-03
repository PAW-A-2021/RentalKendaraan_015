using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Customers = new HashSet<Customer>();
        }

        public int IdGender { get; set; }

        [Required(ErrorMessage = "Nama Gender Tidak Boleh Kosong")]
        [MaxLength(1, ErrorMessage = "Huruf Maksimal 1 karakter")]
        public string NamaGender { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
