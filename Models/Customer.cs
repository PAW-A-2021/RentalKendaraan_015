using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjamen = new HashSet<Peminjaman>();
        }
        
        public int IdCustomer { get; set; }

        [Required(ErrorMessage = "Nama Customer Tidak Boleh Kosong")]
        public string NamaCustomer { get; set; }

        [RegularExpression("^[0-9]*$",ErrorMessage = "Hanya Diisi Oleh Angka")]
        [MaxLength(16, ErrorMessage = "NIK Maksimal 16 angka")]
        public string Nik { get; set; }
        public string Alamat { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Diisi Oleh Angka")]
        [MinLength(10,ErrorMessage ="No HP Minimal 10 angka")]
        [MaxLength(13,ErrorMessage ="No HP Maksimal 13 angka")]
        public string NoHp { get; set; }
        public int? IdGender { get; set; }

        public virtual Gender IdGenderNavigation { get; set; }
        public virtual ICollection<Peminjaman> Peminjamen { get; set; }
    }
}
